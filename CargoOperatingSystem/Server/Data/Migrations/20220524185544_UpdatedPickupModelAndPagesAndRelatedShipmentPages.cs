using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedPickupModelAndPagesAndRelatedShipmentPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pickups_Shipments_ShipmentId",
                table: "Pickups");

            migrationBuilder.DropIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Pickups");

            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "Pickups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PickupAmount",
                table: "Pickups",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Pickups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PickupAmount",
                table: "Arrival",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "38109a06-a855-4869-85f6-d1f8bccd6ac4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "26e34aa7-be07-4abb-92f9-50e9acdc31d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51348bd0-66b8-48ad-9042-fe212e9cc6cd", "AQAAAAEAACcQAAAAEMxNZKc+H6g7HBFMu2HrqiOA2Fw0B6oETKskgHikCvUIabN1xo01ko3xYeJANDs70g==", "f62d587e-c977-4459-82e0-836ef6e210ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65f6076e-7ccd-44b8-a622-64c8fef7cdcc", "AQAAAAEAACcQAAAAEB/d9KCfvvVk55VvOw1RO4+0zaGe7O2uRLywDpa4DN0bXKtjOkl4WIT9HvHnwfi8GA==", "25827a83-c6dc-40cc-94fc-8926b6b6aa91" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 834, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 5, 24, 20, 55, 43, 836, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 837, DateTimeKind.Local).AddTicks(7992), new DateTime(2022, 5, 24, 20, 55, 43, 837, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 837, DateTimeKind.Local).AddTicks(8089), new DateTime(2022, 5, 24, 20, 55, 43, 837, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(1886), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(7307), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(8587), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 5, 24, 20, 55, 43, 838, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 5, 24, 20, 55, 43, 839, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_ArrivalId",
                table: "Pickups",
                column: "ArrivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_SupplierId",
                table: "Pickups",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pickups_Arrival_ArrivalId",
                table: "Pickups",
                column: "ArrivalId",
                principalTable: "Arrival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pickups_Suppliers_SupplierId",
                table: "Pickups",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pickups_Arrival_ArrivalId",
                table: "Pickups");

            migrationBuilder.DropForeignKey(
                name: "FK_Pickups_Suppliers_SupplierId",
                table: "Pickups");

            migrationBuilder.DropIndex(
                name: "IX_Pickups_ArrivalId",
                table: "Pickups");

            migrationBuilder.DropIndex(
                name: "IX_Pickups_SupplierId",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "PickupAmount",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "PickupAmount",
                table: "Arrival");

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Pickups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "39b078e4-bb11-4323-8034-5a1313304689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "cbe5a6fe-581e-4c12-8e3d-72f5ba82270d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad141c58-be42-4dbb-81f7-0d760091a6c9", "AQAAAAEAACcQAAAAEPLy5aBu2WS9Um4k3DjAEbySwVR80lafO2F4ir1j8wE+V9CcMU9srD5jpgHbzplbQg==", "9e5362a3-1561-41d6-af59-f058f4af797b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37ca0db5-4e51-430c-bb40-95b157f344a0", "AQAAAAEAACcQAAAAEHzABrDdfZGuCxPpoFc72WPbUIh+hQsZ9JHnohsjANF06pkzk1j4ap15vpx/aUa91A==", "552e306f-5751-4c4a-9f30-b9c96097b811" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 888, DateTimeKind.Local).AddTicks(4620), new DateTime(2022, 5, 24, 15, 23, 2, 891, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(2952), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(7523), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9395), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(3699), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(4983), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(5003), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups",
                column: "ShipmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pickups_Shipments_ShipmentId",
                table: "Pickups",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
