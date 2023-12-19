using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrdersApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ООО \"Компания 1\"" },
                    { 2, "ООО \"Компания 2\"" },
                    { 3, "ООО \"Компания 3\"" },
                    { 4, "ООО \"Компания 4\"" },
                    { 5, "ООО \"Компания 5\"" },
                    { 6, "ООО \"Компания 6\"" },
                    { 7, "ООО \"Компания 7\"" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Number", "ProviderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-1", 1 },
                    { 2, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-2", 1 },
                    { 3, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "1-3", 1 },
                    { 4, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-1", 2 },
                    { 5, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-2", 2 },
                    { 6, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-3", 2 },
                    { 7, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-1", 3 },
                    { 8, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-2", 3 },
                    { 9, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-3", 3 },
                    { 10, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "4-1", 4 },
                    { 11, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "4-2", 4 },
                    { 12, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "4-3", 4 },
                    { 13, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5-1", 5 },
                    { 14, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "5-2", 5 },
                    { 15, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "5-3", 5 },
                    { 16, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-1", 6 },
                    { 17, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-2", 6 },
                    { 18, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-3", 6 },
                    { 19, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "7-1", 7 },
                    { 20, new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "7-2", 7 },
                    { 21, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "7-3", 7 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 1, "Товар №1", 1, 5m, "м2" },
                    { 2, "Товар №2", 1, 1m, "шт." },
                    { 3, "Товар №3", 2, 8m, "кг" },
                    { 4, "Товар №4", 3, 1m, "м2" },
                    { 5, "Товар №5", 3, 8m, "шт." },
                    { 6, "Товар №6", 4, 5m, "м" },
                    { 7, "Товар №7", 5, 1m, "м" },
                    { 8, "Товар №8", 5, 10m, "т" },
                    { 9, "Товар №9", 6, 10m, "м" },
                    { 10, "Товар №10", 7, 15m, "шт" },
                    { 11, "Товар №11", 7, 3m, "м" },
                    { 12, "Товар №12", 8, 5m, "шт." },
                    { 13, "Товар №13", 9, 4m, "м2" },
                    { 14, "Товар №14", 9, 20m, "т" },
                    { 15, "Товар №15", 10, 5m, "м2" },
                    { 16, "Товар №16", 11, 1m, "шт." },
                    { 17, "Товар №17", 11, 8m, "кг" },
                    { 18, "Товар №18", 12, 1m, "м2" },
                    { 19, "Товар №19", 13, 8m, "шт." },
                    { 20, "Товар №20", 13, 5m, "м" },
                    { 21, "Товар №21", 14, 1m, "м" },
                    { 22, "Товар №22", 15, 10m, "т" },
                    { 23, "Товар №23", 15, 10m, "м" },
                    { 24, "Товар №24", 16, 15m, "шт" },
                    { 25, "Товар №25", 17, 3m, "м" },
                    { 26, "Товар №26", 18, 17m, "шт." },
                    { 27, "Товар №27", 18, 1m, "м2" },
                    { 28, "Товар №28", 19, 16m, "т" },
                    { 29, "Товар №29", 20, 3m, "м" },
                    { 30, "Товар №30", 20, 3m, "шт." },
                    { 31, "Товар №31", 21, 6m, "м2" },
                    { 32, "Товар №32", 21, 30m, "т" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32);

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
