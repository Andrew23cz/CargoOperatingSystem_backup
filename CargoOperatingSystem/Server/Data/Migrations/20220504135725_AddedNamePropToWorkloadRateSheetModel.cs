using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedNamePropToWorkloadRateSheetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "f64c3626-ac0f-46ad-926d-fb13ede17fa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d3719408-86c2-4db5-a18b-2689e9d6514b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30b35d15-e889-490e-a83f-f482e55e54dc", "AQAAAAEAACcQAAAAEHARcFNIXHT67WdEpocVVYBZeTIZm2nr9km5Hl7Bn1V9Z1fb6TdDucDt2RAHEVT/Ag==", "08d0ff4e-9a34-43ee-866f-ad134f1d3c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e86d2058-c375-43b9-80b7-be5249c480ba", "AQAAAAEAACcQAAAAECfr21fAGyW67P/vDBJ8Bs/i6rhGnbTZBTRHapMSJWkD/wm1WYC/y1OZR0/FJ6AStw==", "25dccae1-27c4-43f4-b47c-7a822a518ac5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 252, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 5, 4, 15, 57, 24, 255, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4113), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9943), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9967) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WorkloadRateSheet");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "96aa3278-d17f-4254-a5a8-f253131d5ed5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c3ead253-3b28-45f1-a83e-76b88cd10cc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1f467f-3b7e-4d7c-840d-94dca8e2341b", "AQAAAAEAACcQAAAAEKJZL9HC1oAPtELU7DB17THy6VDAuCUpzcF9w/4nygAfWnKR/EcoU8VHM6TdM8F+lg==", "d232c133-70c2-470f-a188-93b5ddedc4bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "154ed886-f2b4-4b92-8890-e0e55b8f899b", "AQAAAAEAACcQAAAAEC+3QgRC55BubTujBBGvmjy7puqSBifeP1D8rAwA7DQ/kZ30fSMpgQnefmJ/9b6O5A==", "efe45cd4-047b-4088-85c3-13fffcd37edc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 390, DateTimeKind.Local).AddTicks(6661), new DateTime(2022, 5, 4, 15, 10, 0, 393, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2567), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4042), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4063), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(154) });
        }
    }
}
