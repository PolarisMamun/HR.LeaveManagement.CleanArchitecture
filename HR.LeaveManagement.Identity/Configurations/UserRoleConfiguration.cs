using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ec94eb22-7c85-4fe3-82b5-d99c4a031f00",
                    UserId = "5c8aa4c6-8276-4d39-815b-96a242d2b8f9"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "97ebdb83-cb6e-464b-8b9b-20265513d8bb",
                    UserId = "2faa0b9b-efc8-4bed-ba4e-21050e752865"
                }
            );
        }
    }
}