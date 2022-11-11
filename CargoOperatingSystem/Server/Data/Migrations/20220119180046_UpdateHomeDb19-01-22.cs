using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateHomeDb190122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b0d1b9de-a1f0-47db-83ec-ff69aa80e82b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "454f2ea0-ca8b-4d7c-b6e9-0de18b61ac7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76c88626-4a88-4f78-9f84-59a9f0023ff3", "AQAAAAEAACcQAAAAEBqUU1t2G1TyeeZ1qekHFRvUIOTNrfrFH3SXBKIM1Egiq8/tnS5+VZuM5jwOCsHIQw==", "907d0a64-1952-40eb-9474-4d097c588074" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 111, DateTimeKind.Local).AddTicks(7578), new DateTime(2022, 1, 19, 19, 0, 46, 114, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(5023), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6438), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6459), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3055) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "81189344-f1b3-4226-8ee0-3e5f8f755f12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "eed75586-f26c-46c3-9da7-c81f1d8b54b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb972ff1-ba45-4ff0-a8a2-8ebd6fe2f2df", "AQAAAAEAACcQAAAAEB4PEMhGCxSlUOFxr3cNpb55iNJQW2aMOxyeZ4YS69FwuKvwzo1UsFuDzQqatfv69w==", "1926e362-b947-45ce-8aab-b47e86f14913" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 209, DateTimeKind.Local).AddTicks(7433), new DateTime(2022, 1, 19, 16, 34, 43, 222, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8551), new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8846), new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 224, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3479), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3525), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6064), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 227, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 1, 19, 16, 34, 43, 227, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(962), new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(995) });
        }
    }
}
