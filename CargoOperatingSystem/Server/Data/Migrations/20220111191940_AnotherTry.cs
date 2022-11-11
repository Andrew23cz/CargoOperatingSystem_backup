using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AnotherTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "AwbStock");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "AwbStock",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "51306470-4b60-46d3-b380-ab2d83821607");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "bb496ba9-656b-44d0-888e-ad1e42cf6510");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "754ac5a3-36f0-465c-aeb2-64cc7cd00f9d", "AQAAAAEAACcQAAAAEE1KDWfZGbkVw222GeEocO0Mjt/t0F8IPdY/l+Jkq2bzlnbEftGSJlnsvWu71Dd3Og==", "fb005860-32a5-4fc6-bb8b-f439885b4805" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 841, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 1, 11, 19, 43, 13, 843, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6404), new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(786), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2852) });
        }
    }
}
