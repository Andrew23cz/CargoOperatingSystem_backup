using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class kurva02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "3014fc9a-d8f8-486e-baa6-44f4cda23be1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "84138e38-64f1-4437-898d-7bf8e14a6a08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "187f7a7f-57ef-4094-81a7-da787f317258", "AQAAAAEAACcQAAAAEKwVkp93q4jMgcUk5LfSfYsMR1iHPD/8ZHnJgoYaGA6nKkyms/a2arl+VVdhAh6TzA==", "843efa42-b005-4d57-932e-14854aa110e3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 951, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 1, 24, 12, 52, 5, 954, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(1325), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3158), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8040), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4075), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

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
                value: "0fe990a6-fdb6-4f34-9647-a1610f562a9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a0defd98-354b-4f00-a943-a4d8d215f6da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45566441-361a-414e-a9d4-8e82299537d1", "AQAAAAEAACcQAAAAEHv+BTkQG5HX4qSnsb5kJxI+8mQk7yqOmWcdaFARit/hfkoi9RApr0b6coCIsQOoGg==", "b8dbd91c-3265-4a68-8692-5a5a17356ef8" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 269, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 1, 24, 12, 5, 22, 272, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(1033), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(4851), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 1, 24, 12, 5, 22, 273, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2354), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8487), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 1, 24, 12, 5, 22, 274, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true);
        }
    }
}
