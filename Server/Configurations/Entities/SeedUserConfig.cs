using CarRentalApp.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Server.Configurations.Entities
{
    public class SeedUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                    Id = "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "@Office365")
                },
                new ApplicationUser
                {
                    Id = "b68153c1-e3fe-41e7-979f-1ae22a3a1f74",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    FirstName = "Salem",
                    LastName = "Sky",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "@Office365")
                });
        }
    }

    public class SeedUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "8d45faec-a9aa-4a4d-8a8f-ae187d4a3594",
                    RoleId = "89cb05e7-115d-46d8-8fa4-c3614440397d"
                },
                new IdentityUserRole<string>
                {
                    UserId = "b68153c1-e3fe-41e7-979f-1ae22a3a1f74",
                    RoleId = "c32a5c89-e896-437a-ae9d-fbabc03cb9eb"
                });
        }
    }
}
