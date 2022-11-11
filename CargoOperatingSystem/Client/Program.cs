using CargoOperatingSystem.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using CargoOperatingSystem.Client.Services.ShipmentServices;

namespace CargoOperatingSystem.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkwODIzQDMxMzkyZTM0MmUzMFdnbzZKUHJrRlhsUEFNeGlPTWR3MXpXbWdvd0FyNGt1eFlKejZFbUZCYm89");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("CargoOperatingSystem.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CargoOperatingSystem.ServerAPI"));
            builder.Services.AddScoped(typeof(AccountClaimsPrincipalFactory<RemoteUserAccount>), typeof(RolesAccountClaimsPrincipalFactory));
            builder.Services.AddAuthorizationCore(options =>
            {
                options.AddOnlyDsvPolicy();
                options.AddOnlyCargopointPolicy();
                options.AddOnlyCompanyPolicy();
            });

            builder.Services.AddScoped<IShipmentService, ShipmentService>();
            builder.Services.AddScoped<ShipmentAdaptor>();
            
            builder.Services.AddOptions();

            builder.Services.AddApiAuthorization();

            builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

            await builder.Build().RunAsync();
        }
    }
}
