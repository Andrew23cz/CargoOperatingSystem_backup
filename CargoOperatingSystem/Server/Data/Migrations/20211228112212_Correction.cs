using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9b097921-9a0a-4c4e-a04c-01f8e0ecc3c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "40597ccb-d6ee-49be-a258-b055fa5c0610");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "857e01c5-b0b5-43c8-902d-46de18eaff13", "AQAAAAEAACcQAAAAELSykv9wVcb4ojbNJauE2XQ6wdeGYouAFoqW8sITxRcyyNseJ4F1lND8qCZRYpeQzg==", "9bc361f8-5bcd-4a85-b219-c1dd7e3f86e4" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 772, DateTimeKind.Local).AddTicks(2574), new DateTime(2021, 12, 28, 12, 22, 11, 774, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(8954), new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(9046), new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(3220), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(4990), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5012), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(8865), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(209), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(229), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(4024), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6289), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6313), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6315) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
