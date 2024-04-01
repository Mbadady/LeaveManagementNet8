using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailConfirmation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc82097-7afd-4225-8dcf-5e4ff33f9ef9", true, "AQAAAAIAAYagAAAAEBQiV4DkMXBr1EHVQgPptMPcJEvWFycTCboqCDuzeMZiPNnou/RrPDxEEZ4Irz2EHg==", "6990b127-488b-42df-acc1-d28840e12dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edbefd91-4180-401d-80bb-ee592506fa5a", true, "AQAAAAIAAYagAAAAEIjR4dlqBzdFc5DwnHuJJnjE7WhYEtH8NJ1Autg/ms454RSSLKKoJDRLt1u6nJFrHA==", "b0369aa3-be33-4465-b17f-dd468bc0d347" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259054ae-08d8-462f-93f4-ddd044b19594", false, "AQAAAAIAAYagAAAAEIQpOjqygWUzoO0zroXlOwYgmEku3r4hyy4VTlRqOGTPE8Fv4E8ZcfpSvL4WeZCGFQ==", "d3f6eacd-10db-4098-9eeb-572adf5b415e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b3f813-bd53-4e55-a084-4bc82badb87f", false, "AQAAAAIAAYagAAAAEAS+QN7UyAixL1724OY4QtR2l+zt6owfI2w7N49guA+0y+51l7DmVpUHHXSljic5yg==", "df683b56-e784-400c-bd22-afdcca40ffff" });
        }
    }
}
