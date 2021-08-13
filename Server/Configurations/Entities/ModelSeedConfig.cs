using CarRentalApp.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class ModelSeedConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "CAMRY",
                    UpdatedBy = "System"
                },
                new Model
                {
                    Id = 2,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "COROLLA",
                    UpdatedBy = "System"
                },
                   new Model
                   {
                       Id = 3,
                       CreatedBy = "Sysem",
                       DateCreated = DateTime.UtcNow,
                       DateUpdated = DateTime.Now,
                       Name = "PRIUS",
                       UpdatedBy = "System"
                   },
                new Model
                {
                    Id = 4,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "VITZ",
                    UpdatedBy = "System"
                },
                new Model
                {
                    Id =5,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "3 SERIES",
                    UpdatedBy = "System"
                },
                new Model
                {
                    Id = 6,
                    CreatedBy = "Sysem",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.Now,
                    Name = "XS",
                    UpdatedBy = "System"
                });
        }
    }
}
