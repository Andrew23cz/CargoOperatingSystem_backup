using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class MawbShipperModelsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Mawbs",
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
                value: "b8b9b454-e0cd-4275-8947-b3dce7128243");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ef3eaec7-3e84-49d1-9bb0-1ea5c0f33156");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81018f8a-903d-43fc-b409-cc336c126127", "AQAAAAEAACcQAAAAEHoiS9XCEJ2hgTJaIfWHsHmDOwlkxUs++gq0uPvyk5GVK+hrcqLWY4ri6kWcHJbCAg==", "1c60115c-a2b6-4138-9260-95976d58e7ee" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 335, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 20, 21, 47, 55, 337, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(2824), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4543), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4563), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(8114), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9451), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5489), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5512), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Mawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "82ec3722-7361-4dff-b42c-c4485a8103f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "bffdcab4-04ec-463f-9edf-f3726abe69ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df87847-d1e4-40b9-a6b5-0301a55cba4a", "AQAAAAEAACcQAAAAEAjb4DVprsRGV9q1faIHZebKBY+P5PVrtTTxb68fKkemE9RcQ/fECqApVtkju17vXw==", "32341b64-e4cb-47f6-b1ef-e37e47e912ce" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 457, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 1, 20, 19, 50, 34, 460, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6054), new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6152), new DateTime(2022, 1, 20, 19, 50, 34, 461, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(5709), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7012), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 1, 20, 19, 50, 34, 462, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(876), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 1, 20, 19, 50, 34, 463, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true,
                filter: "[ShipmentId] IS NOT NULL");
        }
    }
}
