using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class kurva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "0fe990a6-fdb6-4f34-9647-a1610f562a9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a0defd98-354b-4f00-a943-a4d8d215f6da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45566441-361a-414e-a9d4-8e82299537d1", "AQAAAAEAACcQAAAAEHv+BTkQG5HX4qSnsb5kJxI+8mQk7yqOmWcdaFARit/hfkoi9RApr0b6coCIsQOoGg==", "b8dbd91c-3265-4a68-8692-5a5a17356ef8" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 269, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 1, 24, 12, 5, 22, 272, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(1033), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(4851), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2354), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8487), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8513) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "baaca804-a917-4a39-9614-10a36e25dd16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d8005270-ce1e-480d-b16a-4b29bd64baf1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1063551-72ce-49c9-990d-14eb66727522", "AQAAAAEAACcQAAAAEM5LFfI1e5wUKHVNztOBLa383753IizLXN7exjGK1RSE66Ium/iqBU93PdLdtXJygQ==", "19d55729-8198-4cc4-85ae-159dbe73d7b7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 785, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 1, 24, 11, 33, 58, 788, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 789, DateTimeKind.Local).AddTicks(5802), new DateTime(2022, 1, 24, 11, 33, 58, 789, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 789, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 1, 24, 11, 33, 58, 789, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(78), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(1987), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(5584), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 1, 24, 11, 33, 58, 790, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(1155), new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(3262), new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 1, 24, 11, 33, 58, 791, DateTimeKind.Local).AddTicks(3286) });
        }
    }
}
