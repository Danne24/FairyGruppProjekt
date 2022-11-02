using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class addedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AmountOfCopiesInStorage", "ImageThumbnailUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 25, "\\images2\\fairy1.jpg", false, "Fairy Toy", 70m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AmountOfCopiesInStorage", "AmountOfCopiesSold", "CategoryId", "CurrencyTempKey", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 33, 10, null, 2, null, "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ", "\\images2\\blueWings.jpg", null, true, "Fairy Wings Blue", 100m },
                    { 34, 35, null, 2, null, "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ", "\\images2\\whiteWings.jpg", null, true, "Fairy Wings White", 100m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e212929e-b911-4f62-b3de-116d99d2f89c", "AQAAAAEAACcQAAAAEF+WVNzwlbtgZXphoY5uCajW+TgFV5FbRNK6+JPztAI9gK31VUlj2zh4puRuDShj2A==", "21501fbc-4901-43a3-bfbc-260a8841963b" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "AmountOfCopiesInStorage", "ImageThumbnailUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 53, "\\images2\\pärm.jpg", true, "Folder Blue A4", 35m });
        }
    }
}
