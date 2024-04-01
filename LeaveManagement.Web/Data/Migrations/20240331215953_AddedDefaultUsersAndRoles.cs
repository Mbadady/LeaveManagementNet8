using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "568eba26-57e2-45bc-b0a0-de29411a56f4", null, "Administrator", "ADMINISTRATOR" },
                    { "568eba26-57e2-46bc-b0b0-de29411a56f4", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44", 0, "259054ae-08d8-462f-93f4-ddd044b19594", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", false, "User", "System", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIQpOjqygWUzoO0zroXlOwYgmEku3r4hyy4VTlRqOGTPE8Fv4E8ZcfpSvL4WeZCGFQ==", null, false, "d3f6eacd-10db-4098-9eeb-572adf5b415e", null, false, "user@example.com" },
                    { "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d", 0, "c1b3f813-bd53-4e55-a084-4bc82badb87f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", false, "Admin", "System", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAS+QN7UyAixL1724OY4QtR2l+zt6owfI2w7N49guA+0y+51l7DmVpUHHXSljic5yg==", null, false, "df683b56-e784-400c-bd22-afdcca40ffff", null, false, "admin@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "568eba26-57e2-46bc-b0b0-de29411a56f4", "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44" },
                    { "568eba26-57e2-45bc-b0a0-de29411a56f4", "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "568eba26-57e2-46bc-b0b0-de29411a56f4", "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "568eba26-57e2-45bc-b0a0-de29411a56f4", "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "568eba26-57e2-45bc-b0a0-de29411a56f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "568eba26-57e2-46bc-b0b0-de29411a56f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d");
        }
    }
}
