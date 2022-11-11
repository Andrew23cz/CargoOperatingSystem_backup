using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedDestAirportAndShcCodePropertiesToChargeTemplateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationAirport",
                table: "ChargeTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcCode",
                table: "ChargeTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "cfcd864a-1b16-4ea3-bc0f-793d05d62594");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "201e5af5-e26a-43a1-9152-9e09a65e0b4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f1ff49-b2c0-4086-8c68-922f80eccce7", "AQAAAAEAACcQAAAAEOPezOhAHEZ9ngdMC/c5D5wo2y/tuvdXZg5nepefYfw2DJG0D5wPfghfNm/trmiSLA==", "c6ac8e49-8da6-47fd-8fc6-4fcbaf1ca06c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e49f77a-e500-4398-8395-6f1616b31de7", "AQAAAAEAACcQAAAAEPy8GgB8At03Sc7SnYezf6ETAhHUP3eyGdJ4+w/YSNP7yx+zJeDM6dS0NuzqcGbxwg==", "103c22ab-4d78-4370-9763-53fc17086d1a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 27, DateTimeKind.Local).AddTicks(8618), new DateTime(2022, 5, 12, 13, 48, 23, 30, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(3279), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4589), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(8602), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(611), new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(633), new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(635) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationAirport",
                table: "ChargeTemplate");

            migrationBuilder.DropColumn(
                name: "ShcCode",
                table: "ChargeTemplate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "822ec7ce-4b79-4e9e-bf59-144dc252c07a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f7d23a17-d8ac-4d9f-9dea-a89515d5e396");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f3a408-5cb3-43b8-be4c-167f20f3660f", "AQAAAAEAACcQAAAAEFrw8eeWykoHhU/0Zp6DR459Z1QN8oqeAlX8hQfpRsZ2nUwhBP9Vk6YqvpmecZzH9g==", "7daf30bc-e504-4627-8a02-8a298400a758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48218393-d2d8-4348-bc71-f0bc63298ddd", "AQAAAAEAACcQAAAAEO9WgFNnvqE2GsliS+PrkAiR2moyvLvKixRh3eo6+pMVT9OwsPTBX2+PkyukE7Vcxg==", "864000c6-9b3e-4605-b27e-46cd320ab29b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 92, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 5, 10, 11, 42, 7, 94, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9083), new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9184), new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(423), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(4242), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6229) });
        }
    }
}
