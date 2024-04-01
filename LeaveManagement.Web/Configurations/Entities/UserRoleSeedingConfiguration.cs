using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedingConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                UserId = "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                RoleId = "568eba26-57e2-46bc-b0b0-de29411a56f4"
            });

            builder.HasData(new IdentityUserRole<string>
            {
                UserId = "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                RoleId = "568eba26-57e2-45bc-b0a0-de29411a56f4",
            });
        }
    }
}