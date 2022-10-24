using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class AdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemsId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Chocolate Product" },
                    { 2, "Fruit Product" },
                    { 3, "Gummy Product" },
                    { 4, "Halloween Product" },
                    { 5, "Hard Product" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
