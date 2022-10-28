using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c7f60d29-1f83-4ec8-95f7-3a82f082e9e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc5ccc4-81ed-460e-a93c-d58031a405cb", "AQAAAAEAACcQAAAAEDd9K3cRBtId9xmbo99tsv4iQ/MF2caZwPbfMkh2FFVQRpjVVBrxnAonUC6qyq7N+w==", "db6442a8-a5cb-4d7e-baa5-2c07876f4716" });
        }
    }
}
