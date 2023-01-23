using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alphastellar.Case.DataAccessLayer.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Brand", "Color", "CreatedDate", "Lenght", "Model", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Brand1", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1778), 100, "Model1", null, "Name1" },
                    { 2, "Brand2", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1779), 100, "Model2", null, "Name2" },
                    { 3, "Brand3", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1780), 100, "Model3", null, "Name3" },
                    { 4, "Brand4", "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1781), 100, "Model4", null, "Name4" },
                    { 5, "Brand1", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1783), 100, "Model1", null, "Name1" },
                    { 6, "Brand1", "White", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1784), 100, "Model1", null, "Name1" },
                    { 7, "Brand1", "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1785), 100, "Model1", null, "Name1" },
                    { 8, "Brand8", "Black", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1786), 100, "Model8", null, "Name8" },
                    { 9, "Brand9", "White", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1787), 100, "Model9", null, "Name9" }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Brand", "Capacity", "Color", "CreatedDate", "Model", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Brand1", 100, "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1697), "Model1", null },
                    { 2, "Brand2", 100, "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1698), "Model2", null },
                    { 3, "Brand3", 100, "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1699), "Model3", null },
                    { 4, "Brand4", 100, "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1700), "Model4", null },
                    { 5, "Brand5", 100, "White", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1726), "Model5", null },
                    { 6, "Brand6", 100, "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1727), "Model6", null },
                    { 7, "Brand7", 100, "Black", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1728), "Model7", null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "CreatedDate", "Headlights", "Model", "ModifiedDate", "Wheels" },
                values: new object[,]
                {
                    { 1, "Brand1", "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1554), false, "Model1", null, 4 },
                    { 2, "Brand2", "Red", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1556), false, "Model2", null, 4 },
                    { 3, "Brand3", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1558), false, "Model3", null, 4 },
                    { 4, "Brand4", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1559), false, "Model4", null, 4 },
                    { 5, "Brand1", "Blue", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1560), false, "Model1", null, 4 },
                    { 6, "Brand1", "Black", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1561), false, "Model1", null, 4 },
                    { 7, "Brand1", "White", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1563), false, "Model1", null, 4 },
                    { 8, "Brand1", "White", new DateTime(2023, 1, 22, 12, 24, 40, 207, DateTimeKind.Local).AddTicks(1564), false, "Model1", null, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
