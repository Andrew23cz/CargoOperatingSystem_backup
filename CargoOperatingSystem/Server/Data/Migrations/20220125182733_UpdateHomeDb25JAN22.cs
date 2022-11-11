using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateHomeDb25JAN22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Arrival_ArrivalId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_AwbStock_AwbStockId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_AwbStockId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_ArrivalId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_WorkloadId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "AwbNumber",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "TemplateName",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "WorkloadId",
                table: "Shipments");

            migrationBuilder.RenameColumn(
                name: "AwbStockId",
                table: "Workloads",
                newName: "ShipmentId");

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Arrival",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4707ce73-4f68-411d-8b67-91064c1e703e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f3d6726f-1159-42d2-a713-f65dc0f4f1b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2f5b595-364d-4d54-a1fe-b4b98f177cec", "AQAAAAEAACcQAAAAEJ+0rg0Bn4z9rfasLSGdYC5wI0RfES0QMXD5pULv0aHmNqZRBKc7oGhXVojAbA/OAw==", "fba151d9-2be2-4de1-85a7-511a4d257367" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 487, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 1, 25, 19, 27, 32, 489, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7143), new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(1198), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7956), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4082), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_ShipmentId",
                table: "Workloads",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arrival_ShipmentId",
                table: "Arrival",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Shipments_ShipmentId",
                table: "Arrival",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_Shipments_ShipmentId",
                table: "Workloads",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Shipments_ShipmentId",
                table: "Arrival");

            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_Shipments_ShipmentId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_ShipmentId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Arrival_ShipmentId",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Arrival");

            migrationBuilder.RenameColumn(
                name: "ShipmentId",
                table: "Workloads",
                newName: "AwbStockId");

            migrationBuilder.AddColumn<string>(
                name: "AwbNumber",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateName",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadId",
                table: "Shipments",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_AwbStockId",
                table: "Workloads",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ArrivalId",
                table: "Shipments",
                column: "ArrivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_WorkloadId",
                table: "Shipments",
                column: "WorkloadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Arrival_ArrivalId",
                table: "Shipments",
                column: "ArrivalId",
                principalTable: "Arrival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_AwbStock_AwbStockId",
                table: "Workloads",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
