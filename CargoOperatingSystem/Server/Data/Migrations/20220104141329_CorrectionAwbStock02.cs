using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectionAwbStock02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Airline_AirlineId1",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_AirlineId1",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "AirlineId1",
                table: "AwbStock");

            migrationBuilder.AlterColumn<int>(
                name: "AirlineId",
                table: "AwbStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "735b03c3-7933-4dd2-a062-b6ffb65f1901");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c0213d07-8281-46bb-9f9a-2acb2f55b125");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad05184e-8719-46c0-b84a-51b08a6365d9", "AQAAAAEAACcQAAAAEEP2jnio1tTE1JCaA1IBjXbhfuMH0Rk2zodN2fO+hmn4f1Uk8n1cYWHAcRQDYi+/WA==", "0a121b13-6417-4627-81bc-c2f77e7dd53f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 683, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 1, 4, 15, 13, 27, 696, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1177), new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1399), new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(1170), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(4558), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 703, DateTimeKind.Local).AddTicks(5561), new DateTime(2022, 1, 4, 15, 13, 27, 703, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(553), new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_AirlineId",
                table: "AwbStock",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Airline_AirlineId",
                table: "AwbStock",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Airline_AirlineId",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_AirlineId",
                table: "AwbStock");

            migrationBuilder.AlterColumn<string>(
                name: "AirlineId",
                table: "AwbStock",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AirlineId1",
                table: "AwbStock",
                type: "int",
                nullable: true);

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
                name: "IX_AwbStock_AirlineId1",
                table: "AwbStock",
                column: "AirlineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Airline_AirlineId1",
                table: "AwbStock",
                column: "AirlineId1",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
