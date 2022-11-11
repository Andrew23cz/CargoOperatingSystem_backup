using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectingShipmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "7b20ebd5-e3d3-4081-8132-c2570529b470");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "66fd9ffc-2e72-4c7a-9866-47603bbcccc0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faf1b933-1349-44a9-be2e-b45f744afd01", "AQAAAAEAACcQAAAAEF9fYzS9YhWopMIvt+iy3Dwh8nQuNvkIGuAM+gQ0MDYgG9ZQM7CGM4tLRhh1Pth2MQ==", "878b03db-f79e-43cc-b862-2a09a4d2ac92" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 82, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 1, 24, 11, 23, 48, 85, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(5142), new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(9613), new DateTime(2022, 1, 24, 11, 23, 48, 86, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(1515), new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(1537), new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(6476), new DateTime(2022, 1, 24, 11, 23, 48, 87, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(396), new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(2409), new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(2430), new DateTime(2022, 1, 24, 11, 23, 48, 88, DateTimeKind.Local).AddTicks(2433) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5bee3432-e144-49ef-9348-2455e966e65c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "6ce8b6f7-9af4-4560-869b-b1795b8f6e2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8828f3e-93f9-401d-aa71-45da1c5b0469", "AQAAAAEAACcQAAAAEJnvtUVnF3R36lyEXybOmi2zeEQyPe2S1rojh837xnE21s6m2+lG0FNVnDjQD2pxtQ==", "e94c55f3-bd9d-4786-bb8a-4e05bd1a4f9d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 326, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 22, 15, 19, 15, 329, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3891), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7821), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9625), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9703), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(405), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(430) });
        }
    }
}
