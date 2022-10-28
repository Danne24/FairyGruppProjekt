using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5873ae8c-7bac-4e8c-bf1f-7986a880763e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "464cab84-7ec6-412c-8a6e-70d1da31bb7f", "Admin@localhost", true, "AQAAAAEAACcQAAAAEMpQdENehhuQl4pEaHtnyu6f83G06tFBvxLsToABy9rjcLG+HAjMlF4R6TwLf8jaTg==", "8c956bcc-3361-41e6-a426-88a99622a239" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc07482-9822-450a-8371-f3dd8059920f", null, false, "AQAAAAEAACcQAAAAEAgnTnGohfez21nB6lFibO0atS4k3Ng5pDN+CYzddNDiPVQOXfmYpeMEQrQolYg3OQ==", "9d4e30b4-bed0-4561-802a-4befaa95ff81" });
        }
    }
}
