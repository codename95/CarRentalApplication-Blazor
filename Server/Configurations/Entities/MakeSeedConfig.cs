using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class MakeSeedConfig : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "TOYOTA",
                    UpdatedBy = "System"
                },
                new Color
                {
                    Id= 2,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "BMW",
                    UpdatedBy = "System"
                }, new Make
                {
                    Id = 3,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "LEXUS",
                    UpdatedBy = "System"
                },
                new Color
                {
                    Id = 4,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "MERCEDES-BENZ",
                    UpdatedBy = "System"
                });
        }
    }
}
