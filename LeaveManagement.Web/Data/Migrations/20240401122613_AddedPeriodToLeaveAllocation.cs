using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf30712-a080-4500-9efc-18af13accea7", "AQAAAAIAAYagAAAAEAYykAYSDhCHAck8IArHxD+x88Uls4m3T7cvZyELwtan67fI6OsNhDF5YHKnRQu0Tg==", "770fb902-9cd2-48a9-93e4-86220bbe88c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66928051-db05-4cc2-befc-cf70a1cc0d79", "AQAAAAIAAYagAAAAEGxklt19gV12djCqDaM/Li/X+CM3QuYEPbh+FtKBsxGdFtV57VF2IrX+bO1d1aOPHA==", "b17075ed-4159-4dba-a01b-5e01131438a7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc82097-7afd-4225-8dcf-5e4ff33f9ef9", "AQAAAAIAAYagAAAAEBQiV4DkMXBr1EHVQgPptMPcJEvWFycTCboqCDuzeMZiPNnou/RrPDxEEZ4Irz2EHg==", "6990b127-488b-42df-acc1-d28840e12dc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edbefd91-4180-401d-80bb-ee592506fa5a", "AQAAAAIAAYagAAAAEIjR4dlqBzdFc5DwnHuJJnjE7WhYEtH8NJ1Autg/ms454RSSLKKoJDRLt1u6nJFrHA==", "b0369aa3-be33-4465-b17f-dd468bc0d347" });
        }
    }
}
