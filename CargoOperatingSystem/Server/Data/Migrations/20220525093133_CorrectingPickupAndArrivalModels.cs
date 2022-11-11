using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectingPickupAndArrivalModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pickups_Arrival_ArrivalId",
                table: "Pickups");

            migrationBuilder.DropIndex(
                name: "IX_Pickups_ArrivalId",
                table: "Pickups");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "Pickups");

            migrationBuilder.RenameColumn(
                name: "Pickup",
                table: "Arrival",
                newName: "PickupCheck");

            migrationBuilder.AddColumn<int>(
                name: "PickupId",
                table: "Arrival",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "e40ea091-1c54-4238-ac51-86b8b986571e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "36eb4f2e-57ec-4d4b-99ee-aae0fa2e35ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bed2bb6-cfef-48f4-bdb5-b26a17a849e0", "AQAAAAEAACcQAAAAEK0YGGqB3YOOx2cErgGNVeKYVnMijwV+rOCBY5YKyDFxEzYvNjjIRIP0k7fxO75yCA==", "7ba16b03-a219-4a50-b006-a22d1233eff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36527b7b-325d-4e95-afff-17308d938e89", "AQAAAAEAACcQAAAAEGhyo1TLA3QJf+5N3w0HnIkX9ZbVK/gtgThZvL4O5D+48QH6DcoQvp0FUZp2NkDqmg==", "ce1b35f6-7371-461f-bf5f-89e49ccb2ab3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 38, DateTimeKind.Local).AddTicks(8103), new DateTime(2022, 5, 25, 11, 31, 32, 41, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(2577), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4403), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9584), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(3435), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5454), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.CreateIndex(
                name: "IX_Arrival_PickupId",
                table: "Arrival",
                column: "PickupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Pickups_PickupId",
                table: "Arrival",
                column: "PickupId",
                principalTable: "Pickups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Pickups_PickupId",
                table: "Arrival");

            migrationBuilder.DropIndex(
                name: "IX_Arrival_PickupId",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "PickupId",
                table: "Arrival");

            migrationBuilder.RenameColumn(
                name: "PickupCheck",
                table: "Arrival",
                newName: "Pickup");

            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "Pickups",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pickups_Arrival_ArrivalId",
                table: "Pickups",
                column: "ArrivalId",
                principalTable: "Arrival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
