using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AwbStockAndShipmentRelationshipUpdate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_ShipmentId",
                table: "AwbStock");

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId1",
                table: "AwbStock",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8988c098-11a9-4b87-8fa1-7885fe06a0df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "2cd07e1f-5d93-4299-b531-68f28092816d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ebaaac-a70e-4993-9994-4bf9ab3abb8a", "AQAAAAEAACcQAAAAEKMg7wlvePMrygewr0YNAJ1TAS1AMVfCPISPHKMx4ZaR6SqY9LD2kBzoeM+qoaLReg==", "ffcaedde-33b5-4ffa-9344-f601ce752005" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 191, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 1, 11, 16, 17, 38, 194, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(2138), new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(6029), new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(7754), new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(7774), new DateTime(2022, 1, 11, 16, 17, 38, 195, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(1163), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(2561), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 1, 11, 16, 17, 38, 196, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_ShipmentId1",
                table: "AwbStock",
                column: "ShipmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId1",
                table: "AwbStock",
                column: "ShipmentId1",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId1",
                table: "AwbStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_ShipmentId1",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "ShipmentId1",
                table: "AwbStock");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "7e91df3e-09e2-4a34-88f4-c75b1c7b2f24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "7459856a-aa40-40a3-a49c-3962d1f212ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cea39f3-0606-4486-bcbc-2bcba27524c8", "AQAAAAEAACcQAAAAEPFy/L9L1iPYmHv7dRKvE+ld+xJA574PQ8VzRFvAZj6M+O967JuAJ0BguBwFmBS71A==", "b48c5b38-f3ab-4b45-99d9-5b7a2278cd42" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 43, DateTimeKind.Local).AddTicks(1712), new DateTime(2022, 1, 11, 16, 10, 58, 45, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 47, DateTimeKind.Local).AddTicks(6922), new DateTime(2022, 1, 11, 16, 10, 58, 47, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 47, DateTimeKind.Local).AddTicks(7045), new DateTime(2022, 1, 11, 16, 10, 58, 47, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(7067), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(8378), new DateTime(2022, 1, 11, 16, 10, 58, 48, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(2428), new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(4862), new DateTime(2022, 1, 11, 16, 10, 58, 49, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_ShipmentId",
                table: "AwbStock",
                column: "ShipmentId",
                unique: true,
                filter: "[ShipmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId",
                table: "AwbStock",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id");
        }
    }
}
