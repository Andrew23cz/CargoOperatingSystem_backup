using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedShipmentAwbNumberToShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipmentAwbNumber",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Dimensions",
                type: "int",
                nullable: true);

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
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_Shipments_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropIndex(
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "ShipmentAwbNumber",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Dimensions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "de1ec467-9137-40de-bc42-c9201263d92a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f5ca1da7-701f-4e8a-9b71-b6a5382ccc4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7a7863-1562-4355-a0db-2a7cde1a316f", "AQAAAAEAACcQAAAAECSql5tbT8SZ3qTci78zeZswVkZ2pkQaFB1eSlKa/8UsakFKEwadX5/o09C95sQcQA==", "4cf3235a-3dc7-41f6-a34e-3284c0b2933f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 644, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 1, 5, 10, 20, 30, 657, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5432), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5462), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(780), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2594), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2508), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2541), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2545) });
        }
    }
}
