using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateHomeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9da921eb-dd31-4fc5-9646-11806be7d6fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "afbc4099-4d4a-4f07-ab7d-c4812158dade");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b48af1d-a327-4ec3-96e5-87575e2be369", "AQAAAAEAACcQAAAAEH5rm6ZsB4GSMQB5Og3W+1A/FaHms9Jx15e6ZZIj8YwZ5jQEZbePnciiEPZUYnDiNA==", "ad0b8c10-63bc-4ca9-9b95-fce6e0a6bc66" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 571, DateTimeKind.Local).AddTicks(1284), new DateTime(2022, 1, 5, 19, 45, 40, 573, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(5836), new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 1, 5, 19, 45, 40, 574, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(1516), new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(1538), new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(6319), new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 1, 5, 19, 45, 40, 575, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(202), new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 1, 5, 19, 45, 40, 576, DateTimeKind.Local).AddTicks(2241) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "de1ec467-9137-40de-bc42-c9201263d92a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f5ca1da7-701f-4e8a-9b71-b6a5382ccc4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7a7863-1562-4355-a0db-2a7cde1a316f", "AQAAAAEAACcQAAAAECSql5tbT8SZ3qTci78zeZswVkZ2pkQaFB1eSlKa/8UsakFKEwadX5/o09C95sQcQA==", "4cf3235a-3dc7-41f6-a34e-3284c0b2933f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 644, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 1, 5, 10, 20, 30, 657, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5432), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5462), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(780), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2594), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2508), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2541), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2545) });
        }
    }
}
