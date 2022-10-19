using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "TandläkarGodis", "Chocolate Product" },
                    { 2, "TandläkarGodis", "Fruit Product" },
                    { 3, "TandläkarGodis", "Gummy Product" },
                    { 4, "TandläkarGodis", "Halloween Product" },
                    { 5, "TandläkarGodis", "Hard Product" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Amount", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 0, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "\\Images\\thumbnails\\chocolateProduct-small.jpg", "\\Images\\chocolateProduct.jpg", true, false, "Assorted Chocolate Product", 4.95m },
                    { 2, 0, 1, "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.", "\\Images\\thumbnails\\chocolateProduct2-small.jpg", "\\Images\\chocolateProduct2.jpg", true, true, "Another Assorted Chocolate Product", 3.95m },
                    { 3, 0, 1, "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.", "\\Images\\thumbnails\\chocolateProduct3-small.jpg", "\\Images\\chocolateProduct3.jpg", true, false, "Another Chocolate Product", 5.75m },
                    { 4, 0, 2, "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.", "\\Images\\thumbnails\\fruitProduct-small.jpg", "\\Images\\fruitProduct.jpg", true, false, "Assorted Fruit Product", 3.95m },
                    { 5, 0, 2, "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.", "\\Images\\thumbnails\\fruitProduct2-small.jpg", "\\Images\\fruitProduct2.jpg", true, true, "Fruit Product", 7.00m },
                    { 6, 0, 2, "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ", "\\Images\\thumbnails\\fruitProduct3-small.jpg", "\\Images\\fruitProduct3.jpg", true, true, "Another Assorted Fruit Product", 11.25m },
                    { 7, 0, 3, "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.", "\\Images\\thumbnails\\gummyProduct-small.jpg", "\\Images\\gummyProduct.jpg", true, true, "Assorted Gummy Product", 3.95m },
                    { 8, 0, 3, "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.", "\\Images\\thumbnails\\gummyProduct2-small.jpg", "\\Images\\gummyProduct2.jpg", true, false, "Another Assorted Gummy Product", 1.95m },
                    { 9, 0, 3, "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.", "\\Images\\thumbnails\\gummyProduct3-small.jpg", "\\Images\\gummyProduct3.jpg", true, false, "Gummy Product", 13.95m },
                    { 10, 0, 4, "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.", "\\Images\\thumbnails\\halloweenProduct-small.jpg", "\\Images\\halloweenProduct.jpg", true, true, "Halloween Product", 1.95m },
                    { 11, 0, 4, "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.", "\\Images\\thumbnails\\halloweenProduct2-small.jpg", "\\Images\\halloweenProduct2.jpg", true, true, "Assorted Halloween Product", 12.95m },
                    { 12, 0, 4, "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.", "\\Images\\thumbnails\\halloweenProduct3-small.jpg", "\\Images\\halloweenProduct3.jpg", true, true, "Another Halloween Product", 21.95m },
                    { 13, 0, 5, "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.", "\\Images\\thumbnails\\hardProduct-small.jpg", "\\Images\\hardProduct.jpg", true, false, "Hard Product", 6.95m },
                    { 14, 0, 5, "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.", "\\Images\\thumbnails\\hardProduct2-small.jpg", "\\Images\\hardProduct2.jpg", true, true, "Another Hard Product", 2.95m },
                    { 15, 0, 5, "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.", "\\Images\\thumbnails\\hardProduct3-small.jpg", "\\Images\\hardProduct3.jpg", true, false, "Best Hard Product", 16.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
