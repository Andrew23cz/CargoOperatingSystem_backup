using CargoOperatingSystem.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class ShipperSeedConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasData(new Shipper
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "DHL Forwarding",
                AddressA = "Aviaticka 55, Praha 6, 16000",
                PhoneNumber = 555666999,
                Email = "export@dhl.cz",
                Id = 1
                
            });

            builder.HasData(new Shipper
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "Foxcon cz",
                AddressA = "Industrialni 256, Ostrava, 354442",
                PhoneNumber = 332266448,
                Email = "expedice@foxcon.cz",
                Id = 2

            });

            builder.HasData(new Shipper
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "Pavel Novotny",
                AddressA = "K sidlist 25, Praha 6, 16200",
                PhoneNumber = 604225336,
                Email = "prdel@starosta.cz",
                Id = 3

            });
        }
    }
}
