using CargoOperatingSystem.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class SupplierSeedConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(new Supplier
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "Arrow Mobile",
                HqAddress = "K letisti 25, Praha 6, 16000",
                ContactPersonName = "Petr Pallat",
                Email = "info@arrow.cz",
                InvoicingAddress = "K letisti 25, Praha 6, 16000",
                TaxNumber = "CZ12345678",
                PhoneNumber = 123456789,
                Id = 1

            });

            builder.HasData(new Supplier
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "Mayer",
                HqAddress = "Na Radosti 256, Bratislava, 11100",
                ContactPersonName = "Metr Ojtik",
                Email = "info@mayer.sk",
                InvoicingAddress = "Na Radosti 256, Bratislava, 11100",
                TaxNumber = "SK12345678",
                PhoneNumber = 222333444,
                Id = 2
            });

            builder.HasData(new Supplier
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "Skyport",
                HqAddress = "Laglerove 4, Praha 6, 16100",
                ContactPersonName = "Jan Fero",
                Email = "info@skyport.cz",
                InvoicingAddress = "Laglerove 4, Praha 6, 16100",
                TaxNumber = "CZ12345600",
                PhoneNumber = 555777999,
                Id = 3
            });

            
        }
    }
}
