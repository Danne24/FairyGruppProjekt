using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    public partial class updatedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExactDateOrderplaced",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983d5155-6380-41df-9a36-31ccd392ad3c", "AQAAAAEAACcQAAAAEGkEnUjIhBUm/DeMWLaxUtO5maTN5w0JKQ6HYdhDTwOJssfwrEMBTR8p56ayFiq/3A==", "34a192ca-ac45-4ea0-8dec-d3e4a233d080" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExactDateOrderplaced",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c0d8dda-034b-49e2-9bc0-25fb4327645f", "AQAAAAEAACcQAAAAEBkUqrjXT/A4P6BEnulugkuFq5ftXEu6YsFKupAYpFICHXItL0iXx1wkAvU3JnWLWg==", "13476b75-5b47-4168-a18c-84f89b05492d" });
        }
    }
}
