using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingDefaultUsersCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d9a905fe-e0f0-41c9-8f3c-d4deeb68b357", "AQAAAAEAACcQAAAAENPKQcHwmFIUD70TCN4CZJqvZbiGFGvdccTZK9dMniLqt6+DnrXY4WP/upOSFy0EeQ==", "24d1822f-0be2-4115-9687-007cb7505bed", "admin@localhost.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "875ec595-1c5c-484c-997b-3c123e37af46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "49a2f550-3034-4bc0-a526-a74767f022f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9e5b24c5-a4e2-49cd-9a5a-63bab481f56e", "AQAAAAEAACcQAAAAENrb+tVcfgEl5J6qKs5nkmcbBKHB57QFvFLF8ZwH8C2LdLYTFbY3RbRjWSbQ8F9Stg==", "af29a99f-9a84-4cc6-b0cf-6e648fec36c6", "Admin" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 650, DateTimeKind.Local).AddTicks(3027), new DateTime(2021, 12, 20, 15, 43, 45, 653, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(1147), new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(1236), new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(5224), new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(7065), new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(7085), new DateTime(2021, 12, 20, 15, 43, 45, 654, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(641), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(1979), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(2000), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(6267), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(8367), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreate", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(8389), new DateTime(2021, 12, 20, 15, 43, 45, 655, DateTimeKind.Local).AddTicks(8392) });
        }
    }
}
