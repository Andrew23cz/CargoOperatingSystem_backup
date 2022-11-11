using CargoOperatingSystem.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CargoOperatingSystem.Server.Configurations.Entities
{
    public class ConsigneeSeedConfiguration : IEntityTypeConfiguration<Consignee>
    {
        public void Configure(EntityTypeBuilder<Consignee> builder)
        {
            builder.HasData(new Consignee
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "Pedro Alvarez",
                AddressA = "La Palma 1566, Mexico City",
                Email = "pedro@gmail.com",
                PhoneNumber = 250350450,
                Id = 1
            });

            builder.HasData(new Consignee
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "Liu Chong",
                AddressA = "ShangriLa 255, Shanghai",
                Email = "liu.chong@gmail.com",
                PhoneNumber = 111222555,
                Id = 2
            });

            builder.HasData(new Consignee
            {
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                UpdatedBy = "System",
                DateUpdated = DateTime.Now,
                Name = "Petr Adamec",
                AddressA = "Na Kopci 15, Hradec Kralove",
                Email = "petr.a@seznam.cz",
                PhoneNumber = 111222555,
                Id = 3
            });
        }
    }
}
