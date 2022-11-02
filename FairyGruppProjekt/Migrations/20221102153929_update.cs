using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dacdc503-6ab6-42b6-be0a-4044b5de700b", "AQAAAAEAACcQAAAAEOW6LADd9KeQabqfjAlsWScXKFbJv/C3UNG/H4ATOzkNNHVHWy83/IvRFOqj05dBig==", "08c5a264-f995-4dcd-a649-e634ae3b4f66" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "ImageThumbnailUrl",
                value: "\\images2\\fairy1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "ImageThumbnailUrl",
                value: "\\images2\\blueWings.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "ImageThumbnailUrl",
                value: "\\images2\\whiteWings.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "116c835e-7662-4772-acb4-d9cf19976626", "AQAAAAEAACcQAAAAEAMgPyryio6AvShusPxSpS/mW9tAaMlwRWTm+L3ov+J7jaBy6vKX9mPRSnJmcFM2rQ==", "1c08a040-2cb2-41c3-9a7a-2ad8c1910f58" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "ImageThumbnailUrl",
                value: "\\images2\\fairy1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "ImageThumbnailUrl",
                value: "\\images2\\blueWings.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "ImageThumbnailUrl",
                value: "\\images2\\whiteWings.jpg");
        }
    }
}
