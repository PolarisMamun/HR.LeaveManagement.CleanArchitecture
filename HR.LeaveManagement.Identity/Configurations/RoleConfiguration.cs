using HR.LeaveManagement.Application.Constants;
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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "97ebdb83-cb6e-464b-8b9b-20265513d8bb",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                },
                new IdentityRole
                {
                    Id = "ec94eb22-7c85-4fe3-82b5-d99c4a031f00",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                }
            );
        }
    }
}