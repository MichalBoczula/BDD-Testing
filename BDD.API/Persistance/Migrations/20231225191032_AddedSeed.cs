using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BDD.API.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Identifier", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("ac11a00f-cdf0-4be4-b5b4-ddfbc7f2cb97"), "Order1" },
                    { 2, new Guid("fd74bf90-59c6-40d6-a07c-5df3143a7c8e"), "Order2" },
                    { 3, new Guid("79ecceae-9c19-4f42-9bc7-be8ecc83f70a"), "Order3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Prod1", 100 },
                    { 2, "Prod2", 200 },
                    { 3, "Prod3", 300 },
                    { 4, "Prod4", 400 }
                });

            migrationBuilder.InsertData(
                table: "OrderedProducts",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 2, 3 },
                    { 6, 3, 3 },
                    { 7, 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderedProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
