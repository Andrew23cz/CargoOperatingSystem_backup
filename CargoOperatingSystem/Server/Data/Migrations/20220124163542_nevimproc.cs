using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class nevimproc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Airline_AirlineId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Customers_CustomerId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AirlineId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_CustomerId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "964380ff-c1bf-4fe7-906d-4ece9252e68a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f703812a-bd76-4cbc-a74f-5a45e1ea6066");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9acba909-f27d-48c7-9840-c606028912ce", "AQAAAAEAACcQAAAAEJE3yZlfazzW9wF6TKB9ucn20OFHYFIhCan2oyb3MD3TQ3iM82VDhH3AnS6HTLUuvw==", "2ec0a905-e438-4f11-8ae2-14c64e8a6be7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 913, DateTimeKind.Local).AddTicks(2196), new DateTime(2022, 1, 24, 17, 35, 41, 915, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 916, DateTimeKind.Local).AddTicks(8178), new DateTime(2022, 1, 24, 17, 35, 41, 916, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 916, DateTimeKind.Local).AddTicks(8275), new DateTime(2022, 1, 24, 17, 35, 41, 916, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(2580), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(4547), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(4568), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(9651), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 1, 24, 17, 35, 41, 917, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(3626), new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(5677), new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(5697), new DateTime(2022, 1, 24, 17, 35, 41, 918, DateTimeKind.Local).AddTicks(5699) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "d85ebda2-bc1d-46d1-96e0-74a3f5fbea9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "4abeb40f-6d90-43a3-bd1b-ad3e0d1e7a5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6646fd36-8e18-4b58-b745-7c86bd875c0a", "AQAAAAEAACcQAAAAEEpI11+ykpgKuzPphe1GMR1nzRk5QIe2ssufrVhyPAC3+VyXN+TH31VWt2AYPRLG6w==", "3f66ea54-19d9-4b9c-939a-198b9e66eaf9" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 796, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 1, 24, 13, 25, 24, 799, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(801), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(4823), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1709), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7618), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AirlineId",
                table: "Mawbs",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_CustomerId",
                table: "Mawbs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Airline_AirlineId",
                table: "Mawbs",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Customers_CustomerId",
                table: "Mawbs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
