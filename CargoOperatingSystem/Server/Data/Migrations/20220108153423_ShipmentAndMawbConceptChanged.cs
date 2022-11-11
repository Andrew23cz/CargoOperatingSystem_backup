using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ShipmentAndMawbConceptChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_AwbStock_AwbStockId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Dimensions_AwbStockId",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Dimensions");

            migrationBuilder.AddColumn<double>(
                name: "ChargeableWeight",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GrossWeight",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pieces",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MawbAwbNumber",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Dimensions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8aaac2c7-0e7a-4ca3-b81a-2e685d90d79b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9c1998eb-ae51-49b7-87b3-26b9d1bbbdd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7935ffe8-a2c0-4856-9662-64a81e192e41", "AQAAAAEAACcQAAAAECYrIl06lbTVXSXBZDc4HsnzqsL+L6m1fn/ydhyC/DRcrXjaBJH3EXbsIw+EraMPFw==", "5576a407-d56f-4d82-a744-4bf5c91aef29" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 234, DateTimeKind.Local).AddTicks(646), new DateTime(2022, 1, 8, 16, 34, 23, 236, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5116), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1028), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1049), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(4461), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(9712), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "ChargeableWeight",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "GrossWeight",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "Pieces",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "MawbAwbNumber",
                table: "Mawbs");

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Dimensions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Dimensions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ab6a5d50-e44b-47cf-9b65-49c603ffc911");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8ff1d6e2-ec04-44f7-afd8-ba716e367fcf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece75294-af14-48b4-81e7-8b102e0451d0", "AQAAAAEAACcQAAAAEBqewhnSkW/U2ZBIbmKxQRCYT5/geMNv/+yz8+ALPIhBqSLQ+No4lzmV21weQMeE1w==", "8294a5de-5d15-4d4b-b9e4-51275c38ee6d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 103, DateTimeKind.Local).AddTicks(6318), new DateTime(2022, 1, 8, 11, 4, 57, 106, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(1652), new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(1741), new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(7274), new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 1, 8, 11, 4, 57, 107, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(1109), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(2385), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(2406), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(6275), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(8261), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(8282), new DateTime(2022, 1, 8, 11, 4, 57, 108, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_AwbStockId",
                table: "Dimensions",
                column: "AwbStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_AwbStock_AwbStockId",
                table: "Dimensions",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
