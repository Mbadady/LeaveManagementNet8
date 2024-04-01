using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPeriodToLeaveAllocation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "LeaveAllocations",
                newName: "Period");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8723b27-1d15-4bd5-b5b9-ed7468ff8d44",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0d71a2c-0141-4155-b50b-83b5ee3197a4", "AQAAAAIAAYagAAAAEAME8qiQVaXyztZHUg/YsF729S3oUSWiG4F47Io4GyylPgp1gVE5XBPZFJl366bw1A==", "dd703f6a-9166-4b97-9b55-77045e6f9db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92c7fce-4cc6-409a-af7d-1c378a3c3e2d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f367c6d-b264-440f-9429-d45b3441301b", "AQAAAAIAAYagAAAAEKY29OWELbxnRII2twQkQbymcTNZnpgEPP6cpuTmv6lf3jYnEh7sJvIJ4xjE/ashgw==", "8eeb0318-2329-4abe-bd29-48d4d996cdc7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Period",
                table: "LeaveAllocations",
                newName: "MyProperty");

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
    }
}
