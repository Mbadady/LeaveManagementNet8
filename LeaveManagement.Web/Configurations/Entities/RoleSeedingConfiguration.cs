using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class RoleSeedingConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = "568eba26-57e2-45bc-b0a0-de29411a56f4",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            });

            builder.HasData(new IdentityRole
            {
                Id = "568eba26-57e2-46bc-b0b0-de29411a56f4",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            });




        }
    }
}