using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class updatinghomedb140122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "721515e0-b729-453e-925d-06109a3904b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f7531a1f-1d89-4c20-b906-cf235c1b3ae5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c20c37fd-7364-4792-8dd3-c32d14ebc918", "AQAAAAEAACcQAAAAEHx0vgVVoZ0jyDGiZCGX4+ZlaoHRWmy8aMHCtCTGCgbn1ze4KySB7XEYgWTLHqLDTg==", "31bdeba1-92a0-48e6-b6bc-19b921ed4399" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 284, DateTimeKind.Local).AddTicks(2543), new DateTime(2022, 1, 14, 18, 50, 15, 286, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(7993), new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8085), new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4832), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4853), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4855) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "23aaf49d-1b55-4131-91c2-c3ffb776cc11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8ffbdb8e-d581-49f5-8faf-fb182b1f902e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa7c3dd-f259-4e54-84d8-be70e1fad680", "AQAAAAEAACcQAAAAECuFw8CL7lE2o4BZv8mbnE9U+1WyZocFl3HBLWq2Q92SuMu9824URbA/jtBHgYMFGw==", "80b8b5c7-e119-4323-8d95-4f99091c9a4e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 266, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 1, 14, 15, 7, 7, 278, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5752), new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5912), new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(1824), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3963), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3989), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(9342), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1143), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1169), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(5987), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8358), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8384), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8388) });
        }
    }
}
