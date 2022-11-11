using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3bc7e01-778b-400a-a7f6-3289c681d304", 0, null, "9e5b24c5-a4e2-49cd-9a5a-63bab481f56e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENrb+tVcfgEl5J6qKs5nkmcbBKHB57QFvFLF8ZwH8C2LdLYTFbY3RbRjWSbQ8F9Stg==", null, false, "af29a99f-9a84-4cc6-b0cf-6e648fec36c6", false, "Admin" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6bef2159-5dd7-4924-b8b3-95386f8cc6ef", "b3bc7e01-778b-400a-a7f6-3289c681d304" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6bef2159-5dd7-4924-b8b3-95386f8cc6ef", "b3bc7e01-778b-400a-a7f6-3289c681d304" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "f7196cf1-03a4-486a-9ed5-abe2aff15555");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "515c90f1-ea55-49e6-b243-6395ff16ec28");

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
    }
}
