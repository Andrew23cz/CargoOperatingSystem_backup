using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectingBaseDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Workloads",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Suppliers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Shippers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Shipments",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Orders",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Mawbs",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Invoices",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Hawbs",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Dimensions",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Deliveries",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DateCreate",
                table: "Consignees",
                newName: "DateCreated");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "fad3e2bd-0c31-47d4-941a-8c29b810b46b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0c2f4dd8-3062-4378-9fff-22d6db1e4f0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "725bf43e-3449-409d-ba6a-ce6693ad9fbe", "AQAAAAEAACcQAAAAEOeGfPjyzWaZbkJjmgESfqtkuA4gcTwrmXD3m184KEG8km02GCB1aggrDmKjEPrdpA==", "3cb8d02a-5cb3-4446-9aa9-543ebd3a81dd" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 307, DateTimeKind.Local).AddTicks(3543), new DateTime(2021, 12, 24, 9, 42, 27, 310, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(5491), new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(5592), new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(9582), new DateTime(2021, 12, 24, 9, 42, 27, 311, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(1348), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(1370), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(4793), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(6027), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(6047), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(9914), new DateTime(2021, 12, 24, 9, 42, 27, 312, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 313, DateTimeKind.Local).AddTicks(1901), new DateTime(2021, 12, 24, 9, 42, 27, 313, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 42, 27, 313, DateTimeKind.Local).AddTicks(1923), new DateTime(2021, 12, 24, 9, 42, 27, 313, DateTimeKind.Local).AddTicks(1925) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Workloads",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Suppliers",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Shippers",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Shipments",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Orders",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Mawbs",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Invoices",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Hawbs",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Dimensions",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Deliveries",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DateCreate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Consignees",
                newName: "DateCreate");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee3a6083-a315-4040-a6f3-734e179895ca", "AQAAAAEAACcQAAAAEFTbXCmKJClKFNSfOL6ZBAG3YWBW+ICMUSXdT+dzRjXv1XIEN7A1a67tO0ZV2SL27Q==", "ed3ddcdc-d2f0-46cd-8f7f-678d6acc5513" });

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
    }
}
