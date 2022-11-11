using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectionAwbStock01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Customers_CustomerId1",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_CustomerId1",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "AwbStock");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "AwbStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "cde5de3e-ce79-4837-a23e-4555f3444e92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "435d752c-a19f-4ed2-abbd-9c74f31a4028");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3458211f-0e16-406c-b641-2b6a712c76be", "AQAAAAEAACcQAAAAEIe/SzRVhD5OYOxfLgGond/3Z+YiNjlc/pP9PRg2lE1Uowd1hilDmNw7Y/WJR9pA6A==", "d1c7a094-6f87-4a29-8f55-8096dcd98e9b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 156, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 1, 4, 13, 7, 45, 257, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 262, DateTimeKind.Local).AddTicks(7771), new DateTime(2022, 1, 4, 13, 7, 45, 262, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 262, DateTimeKind.Local).AddTicks(8324), new DateTime(2022, 1, 4, 13, 7, 45, 262, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 264, DateTimeKind.Local).AddTicks(5319), new DateTime(2022, 1, 4, 13, 7, 45, 264, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 265, DateTimeKind.Local).AddTicks(895), new DateTime(2022, 1, 4, 13, 7, 45, 265, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 265, DateTimeKind.Local).AddTicks(964), new DateTime(2022, 1, 4, 13, 7, 45, 265, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(6285), new DateTime(2022, 1, 4, 13, 7, 45, 266, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(349), new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(5798), new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(5868), new DateTime(2022, 1, 4, 13, 7, 45, 268, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_CustomerId",
                table: "AwbStock",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Customers_CustomerId",
                table: "AwbStock",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Customers_CustomerId",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_CustomerId",
                table: "AwbStock");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "AwbStock",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "AwbStock",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "93471b3e-5b0e-4254-a4d2-b4fc2ea4edbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "527f2937-e5f1-4efe-bea6-3379c806c327");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bad85a4-77ce-4b16-9f63-77a675bca4c8", "AQAAAAEAACcQAAAAELzNcC3pk/76m+PpO7Q/8S7SGYnjzVTQWipHJvcc1UHTP5BFTWUNad2m27DcXhDwEA==", "6d8728d6-02bc-4d35-8d73-5a3a35dd7d89" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 33, DateTimeKind.Local).AddTicks(6352), new DateTime(2022, 1, 4, 12, 10, 50, 46, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1681), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(8795), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(737), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5100), new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_CustomerId1",
                table: "AwbStock",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Customers_CustomerId1",
                table: "AwbStock",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
