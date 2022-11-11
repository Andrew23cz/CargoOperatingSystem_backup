using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingDefaultUsersCorrection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "67a55f02-2056-4131-b5e6-b790a3a1d4d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ddd528ad-701c-44ae-9516-7361f202830b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee3a6083-a315-4040-a6f3-734e179895ca", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFTbXCmKJClKFNSfOL6ZBAG3YWBW+ICMUSXdT+dzRjXv1XIEN7A1a67tO0ZV2SL27Q==", "ed3ddcdc-d2f0-46cd-8f7f-678d6acc5513" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 464, DateTimeKind.Local).AddTicks(8104), new DateTime(2021, 12, 20, 15, 54, 22, 467, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(2278), new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(2373), new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(6152), new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(8078), new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(8099), new DateTime(2021, 12, 20, 15, 54, 22, 468, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(1578), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(2889), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(2918), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(6755), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(8806), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(8826), new DateTime(2021, 12, 20, 15, 54, 22, 469, DateTimeKind.Local).AddTicks(8829) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "30b5ddb3-5b39-4542-9973-3a607c6a6650");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b3c78bd0-6319-4bdb-b2f0-639f3381db23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a905fe-e0f0-41c9-8f3c-d4deeb68b357", "ADMIN", "AQAAAAEAACcQAAAAENPKQcHwmFIUD70TCN4CZJqvZbiGFGvdccTZK9dMniLqt6+DnrXY4WP/upOSFy0EeQ==", "24d1822f-0be2-4115-9687-007cb7505bed" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 232, DateTimeKind.Local).AddTicks(5350), new DateTime(2021, 12, 20, 15, 50, 8, 235, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(33), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(123), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(4067), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(5899), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(5921), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(9305), new DateTime(2021, 12, 20, 15, 50, 8, 236, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(546), new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(566), new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(4418), new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(6363), new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(6384), new DateTime(2021, 12, 20, 15, 50, 8, 237, DateTimeKind.Local).AddTicks(6387) });
        }
    }
}
