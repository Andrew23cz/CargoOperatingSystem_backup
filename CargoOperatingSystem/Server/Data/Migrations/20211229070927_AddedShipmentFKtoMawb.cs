using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedShipmentFKtoMawb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Mawbs_MawbId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_MawbId",
                table: "Shipments");

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "41c020c8-8ebb-4ef0-944f-6333c4921828");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "142771c9-9351-4fe3-ab70-8e8a0b9d19dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058adb82-a897-4e0d-b91a-ea290b751493", "AQAAAAEAACcQAAAAEMK61Cf8NtpfmmV1VSQunqwOv1n9UexoWGv6iyWOrspt2JXxmV/uxK+Cmk5sdXnqQA==", "6032758d-33bb-4012-ae6c-a444955af8f2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 912, DateTimeKind.Local).AddTicks(8037), new DateTime(2021, 12, 29, 8, 9, 26, 915, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3156), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3245), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(7103), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8884), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8904), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(2587), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3960), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3979), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(7868), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9796), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9b097921-9a0a-4c4e-a04c-01f8e0ecc3c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "40597ccb-d6ee-49be-a258-b055fa5c0610");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "857e01c5-b0b5-43c8-902d-46de18eaff13", "AQAAAAEAACcQAAAAELSykv9wVcb4ojbNJauE2XQ6wdeGYouAFoqW8sITxRcyyNseJ4F1lND8qCZRYpeQzg==", "9bc361f8-5bcd-4a85-b219-c1dd7e3f86e4" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 772, DateTimeKind.Local).AddTicks(2574), new DateTime(2021, 12, 28, 12, 22, 11, 774, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(8954), new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(9046), new DateTime(2021, 12, 28, 12, 22, 11, 775, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(3220), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(4990), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5012), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(8865), new DateTime(2021, 12, 28, 12, 22, 11, 776, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(209), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(229), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(4024), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6289), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6313), new DateTime(2021, 12, 28, 12, 22, 11, 777, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_MawbId",
                table: "Shipments",
                column: "MawbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Mawbs_MawbId",
                table: "Shipments",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
