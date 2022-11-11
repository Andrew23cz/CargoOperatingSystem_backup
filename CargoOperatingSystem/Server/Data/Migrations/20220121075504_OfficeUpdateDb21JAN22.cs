using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class OfficeUpdateDb21JAN22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1922f0b5-4f4d-42a9-be2c-7dbad3bb8020");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "97835654-a572-45cf-9c0f-fda1ff1b6bbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af9e99b0-8af5-4abb-8a48-178ee9d73020", "AQAAAAEAACcQAAAAEDlpKEKXKFgdtVQ473dg6eFB8K9nlNxla8b5bUTaz62//lFEb3npS/BC1h1JOSLFiA==", "33e2e0fa-0259-4888-8ad2-ad6c18c6a341" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 102, DateTimeKind.Local).AddTicks(4660), new DateTime(2022, 1, 21, 8, 55, 3, 116, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(8712), new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(8742), new DateTime(2022, 1, 21, 8, 55, 3, 118, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(4909), new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(6706), new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(6731), new DateTime(2022, 1, 21, 8, 55, 3, 119, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(2614), new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(5239), new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(5268), new DateTime(2022, 1, 21, 8, 55, 3, 120, DateTimeKind.Local).AddTicks(5271) });
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
