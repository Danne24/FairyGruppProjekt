using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class TestTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6a9cd177-d0a8-4a30-9f17-6cc7d36a10ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc07482-9822-450a-8371-f3dd8059920f", "AQAAAAEAACcQAAAAEAgnTnGohfez21nB6lFibO0atS4k3Ng5pDN+CYzddNDiPVQOXfmYpeMEQrQolYg3OQ==", "9d4e30b4-bed0-4561-802a-4befaa95ff81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2d48ade9-6d36-4c7d-98b4-d8c325f6e3d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db611676-3d79-4e89-8820-5cf3a182a3f5", "AQAAAAEAACcQAAAAEGuKruQKMs7Et1Tc0YyjSRG9LEzg26kX27ApiBxIQeOvzac1yUGw+UApvkY6kal0iw==", "340e9500-ec0e-4b6a-8731-65a28123bdc6" });
        }
    }
}
