using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateOfficeDb13JAN22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "71b09ec5-9b68-4c45-8c64-8d1b5e34b0e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "79d29c8a-371a-4410-a9c2-9ff8f073895c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c25e474e-56dc-443f-ab35-9dd62108bf96", "AQAAAAEAACcQAAAAEJ2NHGj1Wh3WJ0q4/Eaao5meZEh+sMfhzNN/J0pUSatb8fgEJGDy2qVpohkzvJdxLQ==", "1d4ae6ee-963b-4fe3-bce0-7b055fa38a38" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 260, DateTimeKind.Local).AddTicks(1032), new DateTime(2022, 1, 13, 9, 0, 0, 275, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8817), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 279, DateTimeKind.Local).AddTicks(9407), new DateTime(2022, 1, 13, 9, 0, 0, 279, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1787), new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(4216), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8191) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "aef80a44-6f53-4a2b-8250-fafaeb691d39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e16e128c-87d4-4f68-b58a-47cbc887979f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bf4f600-6092-4893-b503-ae48440d7e0b", "AQAAAAEAACcQAAAAENs9Jo3c0uupnBLve6g85qr8nVGKgXFBU6yeape3afXmhBNQj8w2ovKmG7B1hHJylQ==", "e6def619-b778-4f8c-85d1-832a7e975d58" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 834, DateTimeKind.Local).AddTicks(2084), new DateTime(2022, 1, 11, 20, 19, 39, 836, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 837, DateTimeKind.Local).AddTicks(7325), new DateTime(2022, 1, 11, 20, 19, 39, 837, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 837, DateTimeKind.Local).AddTicks(7431), new DateTime(2022, 1, 11, 20, 19, 39, 837, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(1457), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(6998), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(8375), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 1, 11, 20, 19, 39, 838, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(4134), new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(4155), new DateTime(2022, 1, 11, 20, 19, 39, 839, DateTimeKind.Local).AddTicks(4157) });
        }
    }
}
