using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AwbStockAndShipmentRelationshipUpdate02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "944ab3b8-a25e-4a06-89cc-95bb9fe50484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b4a849fa-5909-42b1-be8e-4414ef94109b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69db03e0-9663-47ae-b62b-128767fb5ef6", "AQAAAAEAACcQAAAAED3rL7Nf2GsBMHZ7mYAUKrlvC4IDNOriZqyPHm8yGwc1k4mYrRxVR+HOKjlHKoZ9SA==", "57d7ecdc-81f6-4af3-8fda-da476c4c7d3b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 764, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 11, 19, 40, 31, 766, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8557), new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9014), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9033), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(2749), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments");

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
    }
}
