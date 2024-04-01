using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedingConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var passwordHasher = new PasswordHasher<Employee>();
            builder.HasData(new Employee
            {
                FirstName = "User",
                LastName = "System",
                Email = "user@example.com",
                Id = "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                PasswordHash = passwordHasher.HashPassword(null, "Mbadady1_"),
                NormalizedEmail = "USER@EXAMPLE.COM",
                NormalizedUserName = "USER@EXAMPLE.COM",
                UserName = "user@example.com",
                EmailConfirmed = true

            });

            builder.HasData(new Employee
            {
                FirstName = "Admin",
                LastName = "System",
                Email = "admin@example.com",
                Id = "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                PasswordHash = passwordHasher.HashPassword(null, "Mbadady1_"),
                EmailConfirmed = true
            });
        }
    }
}