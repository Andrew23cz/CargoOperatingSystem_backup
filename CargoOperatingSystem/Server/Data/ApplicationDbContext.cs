using CargoOperatingSystem.Server.Configurations.Entities;
using CargoOperatingSystem.Server.Models;
using CargoOperatingSystem.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CargoOperatingSystem.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Invoice>().Property(x => x.InvoiceAmount).HasColumnType("decimal").HasPrecision(12, 4); ;
            builder.Entity<Order>().Property(x => x.OrderAmount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Delivery>().Property(x => x.DeliveryAmount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Workload>().Property(x => x.WorkloadAmount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.MinimumRate).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.NormalFlatRate).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak45).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak100).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak250).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak300).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak500).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.RateWeightBreak1000).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.PivotWeight).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.PivotRate).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.FlatPrice).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<AfRates>().Property(x => x.OverPivotRate).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Currency>().Property(x => x.ExchangeRate).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Charge>().Property(x => x.Amount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<ChargeTemplate>().Property(x => x.Amount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AwbIssuing).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.HawbIssuing).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.CargoLabels).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AcceptanceAssist).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.DocumentsCorrection).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.ImportCgoProcessing).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.PrintingCorrectedDocs).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.SpecCargoLabels).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AfterOpeningHoursService).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.ManualDataInsertion).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.PickUpDocuments).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.SecurityCheckPrepare).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.SecurityCheckAssist).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.PackingAssist).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AcceptanceAssistDG).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.CosultingDG).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AdditionalServiceA).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AdditionalServiceB).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AdditionalServiceC).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AdditionalServiceD).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<WorkloadRateSheet>().Property(x => x.AdditionalServiceE).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Arrival>().Property(x => x.PickupAmount).HasColumnType("decimal").HasPrecision(12, 4);
            builder.Entity<Pickup>().Property(x => x.PickupAmount).HasColumnType("decimal").HasPrecision(12, 4);
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ConsigneeSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new ShipperSeedConfiguration());
            builder.ApplyConfiguration(new SupplierSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            
            builder.Entity<AwbStock>()
                .HasOne(a => a.Shipment)
                .WithOne(b => b.AwbStock)
                .HasForeignKey<Shipment>(a => a.AwbStockId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Currency>()
                .HasMany(a => a.ChargeTemplates)
                .WithOne(b => b.Currency)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Currency>()
                .HasMany(a => a.AfRates)
                .WithOne(b => b.Currency)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Currency>()
                .HasMany(a => a.Charges)
                .WithOne(b => b.Currency)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Currency>()
                .HasMany(a => a.WorkloadRateSheets)
                .WithOne(b => b.Currency)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Shipment>()
                .HasOne(a => a.Mawb)
                .WithOne(b => b.Shipment)
                .HasForeignKey<Mawb>(c => c.ShipmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Arrival>()
                .HasOne(a => a.Supplier)
                .WithMany(b => b.Arrivals)
                .HasForeignKey(a => a.SupplierId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Charge>()
                .HasOne(a => a.Supplier)
                .WithMany(b => b.Charges)
                .HasForeignKey(a => a.SupplierId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Mawb>()
                .HasOne(a => a.Shipper)
                .WithMany(b => b.Mawbs)
                .HasForeignKey(a => a.ShipperId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Hawb>()
                .HasOne(a => a.Shipper)
                .WithMany(b => b.Hawbs)
                .HasForeignKey(a => a.ShipperId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Mawb>()
                .HasOne(a => a.Consignee)
                .WithMany(b => b.Mawbs)
                .HasForeignKey(a => a.ConsigneeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Hawb>()
                .HasOne(a => a.Consignee)
                .WithMany(b => b.Hawbs)
                .HasForeignKey(a => a.ConsigneeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Hawb>()
                .HasOne(a => a.Mawb)
                .WithMany(b => b.Hawbs)
                .HasForeignKey(a => a.MawbId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<AgentSubmitMawb>()
                .HasOne(a => a.AgentSubmitShipper)
                .WithMany(b => b.AgentSubmitMawbs)
                .HasForeignKey(a => a.AgentSubmitShipperId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AgentSubmitHawb>()
                .HasOne(a => a.AgentSubmitShipper)
                .WithMany(b => b.AgentSubmitHawbs)
                .HasForeignKey(a => a.AgentSubmitShipperId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AgentSubmitMawb>()
                .HasOne(a => a.AgentSubmitConsignee)
                .WithMany(b => b.AgentSubmitMawbs)
                .HasForeignKey(a => a.AgentSubmitConsigneeId)
                .OnDelete(DeleteBehavior.SetNull);


            builder.Entity<AgentSubmitHawb>()
                .HasOne(a => a.AgentSubmitConsignee)
                .WithMany(b => b.AgentSubmitHawbs)
                .HasForeignKey(a => a.AgentSubmitConsigneeId)
                .OnDelete(DeleteBehavior.SetNull);







        }

        public DbSet<Consignee> Consignees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Pickup> Pickups { get; set; }
        public DbSet<Hawb> Hawbs { get; set; }
        public DbSet<Mawb> Mawbs { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Workload> Workloads { get; set; }
        public DbSet<Arrival> Arrival { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<AwbStock> AwbStock { get; set; }
        public DbSet<AfRates> AfRates { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Charge> Charge { get; set; }
        public DbSet<Dimmension> Dimmension { get; set; }
        public DbSet<AgentSubmitConsignee> AgentSubmitConsignee { get; set; }
        public DbSet<AgentSubmitShipper> AgentSubmitShipper { get; set; }
        public DbSet<AgentSubmitModel> AgentSubmitModel { get; set; }
        public DbSet<AgentSubmitDim> AgentSubmitDim { get; set; }
        public DbSet<AgentSubmitMawb> AgentSubmitMawb { get; set; }
        public DbSet<AgentSubmitHawb> AgentSubmitHawb { get; set; }
        public DbSet<ChargeTemplate> ChargeTemplate { get; set; }
        public DbSet<CargoOperatingSystem.Shared.Domain.WorkloadRateSheet> WorkloadRateSheet { get; set; }


    }
}
