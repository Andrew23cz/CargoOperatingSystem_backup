using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class RenameTableChargesToCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name:"Charges", newName:"Charge");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a72263dc-d45d-410b-94f5-ee18cd4c12f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "25bab109-49dc-4f10-986e-b6d7b1cf5856");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70536153-a70a-4e57-a37d-86f62d685783", "AQAAAAEAACcQAAAAEGwNZ0dFTTyhB+svLOQ5qw0z9Qkcp9rQGmgO9CUDOhSUeaDwb+d1AYXnMygs7UDUcA==", "93f3b359-9819-4937-8bd1-bb343ee841f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f50f01-494c-4e67-b58c-1b362fa2879c", "AQAAAAEAACcQAAAAEFBHdB4TwFTj9zc0fXs1wW0jWah4VxaGQdbQfdDenwyDaxKYJsTgnJmjiV46Mhb6zw==", "773c5aa2-cdc4-4ac8-b1e1-42ccf1a8958e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 320, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 4, 9, 14, 49, 21, 323, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8263), new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8369), new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4773), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9799), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9822), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Charge", newName: "Charges");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "3305b63a-3768-44bb-92e4-1fcae5125f20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "aa010e59-8a2e-4563-9b36-4eaa8b40ef56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956dfa1d-6bd4-4b5a-bb78-bcaed90150cd", "AQAAAAEAACcQAAAAECoWeztySlnWDClvBrdGodbdFMP7ZE0Ln6FnOtd0n8bFNUENfrVMVgE4IBFhYQvUVg==", "dd636004-5008-4d48-b6b0-357a57dcb13b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52247c2c-05ad-461e-863b-645a10224b28", "AQAAAAEAACcQAAAAEK7qVTt7BHJ+7t282iAOGrnJhpuQIAWdLgmLlcqDHsnp5OZDQyVoYPYeTWWaPjydeg==", "0a74d9e8-be13-4985-a8b9-0c249bc31e63" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 412, DateTimeKind.Local).AddTicks(4206), new DateTime(2022, 4, 9, 14, 39, 51, 415, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(1655), new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(5873), new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(7667), new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 4, 9, 14, 39, 51, 416, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(2600), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(6607), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(8574), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(8595), new DateTime(2022, 4, 9, 14, 39, 51, 417, DateTimeKind.Local).AddTicks(8597) });
        }
    }
}
