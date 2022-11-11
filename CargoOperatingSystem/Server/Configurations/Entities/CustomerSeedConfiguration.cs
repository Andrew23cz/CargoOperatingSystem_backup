using CargoOperatingSystem.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new Customer
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "Fiege",
                HqAddressA = "K letisti 15, Praha 6",
                InvoicingAddressA = "K letisti 15, Praha 6",
                TaxNumber = "CZ12345678",
                Email = "fiege.export@gmail.com",
                PhoneNumber = 123456789,
                Id = 1
            });

            builder.HasData(new Customer
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "Agility",
                HqAddressA = "U Zlicina 25, Praha 6",
                InvoicingAddressA = "U Zlicina 25, Praha 6",
                TaxNumber = "CZ11145678",
                Email = "air.export@agility.cz",
                PhoneNumber = 222333666,
                Id = 2
            });

            builder.HasData(new Customer
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                CompanyName = "ATS",
                HqAddressA = "Laglerove 4, Praha 6",
                InvoicingAddressA = "Laglerove 4, Praha 6",
                TaxNumber = "CZ22245678",
                Email = "export@ats.com",
                PhoneNumber = 444666888,
                Id = 3
            });
        }
    }
}
