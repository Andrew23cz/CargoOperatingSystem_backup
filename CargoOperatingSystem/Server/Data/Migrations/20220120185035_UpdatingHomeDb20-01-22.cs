using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingHomeDb200122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "82ec3722-7361-4dff-b42c-c4485a8103f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "bffdcab4-04ec-463f-9edf-f3726abe69ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df87847-d1e4-40b9-a6b5-0301a55cba4a", "AQAAAAEAACcQAAAAEAjb4DVprsRGV9q1faIHZebKBY+P5PVrtTTxb68fKkemE9RcQ/fECqApVtkju17vXw==", "32341b64-e4cb-47f6-b1ef-e37e47e912ce" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 457, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 1, 20, 19, 50, 34, 460, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6054), new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(5709), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7012), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(876), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2868) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "fe784d90-a250-4541-82fb-b2f509c2dc0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "3cdd5d88-3153-42e4-9fb1-7651d637e86d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "202fe533-0dc1-47f5-aab9-838bce12e93d", "AQAAAAEAACcQAAAAEIw+sbwq7IPq//uQZWrHu77X5lcndU5Fggf+yJZC0RCue7qrlzljRvrmf9jQ1b0hOQ==", "6b64e99d-6197-4f64-b42f-7f83bace1882" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 186, DateTimeKind.Local).AddTicks(3947), new DateTime(2022, 1, 20, 16, 32, 55, 232, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(7045), new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8360), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8396), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(6241), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8374), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8407), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(1640), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7009), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7080) });
        }
    }
}
