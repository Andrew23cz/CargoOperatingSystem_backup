using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac", "515c90f1-ea55-49e6-b243-6395ff16ec28", "User", "USER" },
                    { "6bef2159-5dd7-4924-b8b3-95386f8cc6ef", "f7196cf1-03a4-486a-9ed5-abe2aff15555", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 168, DateTimeKind.Local).AddTicks(7581), new DateTime(2021, 12, 20, 15, 15, 39, 172, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 173, DateTimeKind.Local).AddTicks(7378), new DateTime(2021, 12, 20, 15, 15, 39, 173, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 173, DateTimeKind.Local).AddTicks(7478), new DateTime(2021, 12, 20, 15, 15, 39, 173, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(1878), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(3933), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(3958), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(7528), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(8764), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(8785), new DateTime(2021, 12, 20, 15, 15, 39, 174, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(2520), new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(4572), new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(4593), new DateTime(2021, 12, 20, 15, 15, 39, 175, DateTimeKind.Local).AddTicks(4596) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac");

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 592, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 12, 20, 14, 54, 44, 595, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4807), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4899), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(9049), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(795), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(4379), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5634), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5655), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1269), new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1291), new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1294) });
        }
    }
}
