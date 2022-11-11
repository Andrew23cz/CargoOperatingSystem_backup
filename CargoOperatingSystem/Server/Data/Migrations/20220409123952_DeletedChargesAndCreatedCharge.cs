using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class DeletedChargesAndCreatedCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5fceaa30-9f70-4492-92c4-47c1467f6fe1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "988767f6-bc93-45cf-ad1b-385d9c572b00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a8b3530-50de-4ce4-a635-265c8ab96ace", "AQAAAAEAACcQAAAAEIWD9fGT6GWS2O2f1QLH7tue+v/o37bnZEqU7binaw6gtQXQpkUOLedZPP2pJtkM1A==", "380db220-afd3-4812-b490-889db0ff4f5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b45b9ee-2008-4d2f-8cb0-181ef6cff0d2", "AQAAAAEAACcQAAAAEF18HULkuVqRGtlXu4JHgCr7ZzD/LXguJdJ8xEoBqrPpWFs1DI6U8DHM1W7Qm433tg==", "3063b32d-9fa9-44aa-a127-344c5c198e54" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 559, DateTimeKind.Local).AddTicks(4135), new DateTime(2022, 4, 9, 11, 58, 31, 562, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3612), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3711), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(7781), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9532), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(9036), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(986), new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1011) });
        }
    }
}
