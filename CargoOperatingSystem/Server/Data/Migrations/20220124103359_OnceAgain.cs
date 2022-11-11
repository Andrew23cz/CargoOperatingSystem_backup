using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class OnceAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a53cbe73-1a8f-4b92-a734-74cd56ef22e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c3ad064-be50-443b-b073-6a52fb2cf944");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9df07972-7545-46d9-b80f-9ec58170bc8e", "AQAAAAEAACcQAAAAENXdn0sYYLwSkiVqlYKOFlRm1JpttyXbd2jBo4h9mYIBIfvfcWnzhwrnOM4gj/C4/A==", "587e1659-0800-4958-8a66-93059737b9ff" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 118, DateTimeKind.Local).AddTicks(5767), new DateTime(2022, 1, 24, 11, 28, 57, 121, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2703), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(7863), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9808), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1264), new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1286), new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1288) });
        }
    }
}
