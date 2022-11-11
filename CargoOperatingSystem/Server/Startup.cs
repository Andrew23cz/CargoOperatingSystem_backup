using CargoOperatingSystem.Server.Data;
using CargoOperatingSystem.Server.IRepository;
using CargoOperatingSystem.Server.Models;
using CargoOperatingSystem.Server.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using IdentityModel;

using CargoOperatingSystem.Shared;
using Newtonsoft.Json.Serialization;

namespace CargoOperatingSystem.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"))
                    .EnableSensitiveDataLogging());

            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, AdditionalUserClaimsPrincipalFactory>();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddClaimsPrincipalFactory<AdditionalUserClaimsPrincipalFactory>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
                {
                    const string OpenId = "openid";

                    options.IdentityResources[OpenId].UserClaims.Add(CustomClaimTypes.Company);
                    options.ApiResources.Single().UserClaims.Add(CustomClaimTypes.Company);

                    options.IdentityResources[OpenId].UserClaims.Add(JwtClaimTypes.Email);
                    options.ApiResources.Single().UserClaims.Add(JwtClaimTypes.Email);

                    options.IdentityResources[OpenId].UserClaims.Add(JwtClaimTypes.Role);
                    options.ApiResources.Single().UserClaims.Add(JwtClaimTypes.Role);

                });

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove(JwtClaimTypes.Role);
            services.AddAuthentication().AddIdentityServerJwt();


            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddControllersWithViews().AddNewtonsoftJson(op=> op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddRazorPages();
            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

            services.AddAuthorization(options =>
            {
                options.AddOnlyDsvPolicy();
                options.AddOnlyCargopointPolicy();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env,
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {

            //ApplicationDbInitialiser.SeedRoles(roleManager);
            //ApplicationDbInitialiser.SeedUsers(userManager);

            // Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkwODIzQDMxMzkyZTM0MmUzMFdnbzZKUHJrRlhsUEFNeGlPTWR3MXpXbWdvd0FyNGt1eFlKejZFbUZCYm89");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
