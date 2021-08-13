using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class ColorSeedConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "Black",
                    UpdatedBy = "System"
                },
                new Color
                {
                    Id = 2,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "Red",
                    UpdatedBy = "System"
                });
        }
    }
}
