using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ChangedMawbHawbShipmentAwbNumbertoPlainAwbNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShipmentAwbNumber",
                table: "Shipments",
                newName: "AwbNumber");

            migrationBuilder.RenameColumn(
                name: "MawbAwbNumber",
                table: "Mawbs",
                newName: "AwbNumber");

            migrationBuilder.AddColumn<string>(
                name: "AwbNumber",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9d1454bb-cca2-452f-bd2c-a531df5c566e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "21774e0f-e031-458f-82a8-8d9e1ba31795");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d793b65-467c-419b-9938-e8efb620eea9", "AQAAAAEAACcQAAAAEEvkdQGzf3CKu1/impXohoepRdVxY3jekgn0v0lN1yDu1hr/WW/R6yuU1af5+OhsDw==", "fa2fb41f-b6b8-495a-a7ad-9a97cec2d0d5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 422, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 1, 26, 16, 5, 13, 425, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1579), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6536), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2686), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2707), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2710) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbNumber",
                table: "Hawbs");

            migrationBuilder.RenameColumn(
                name: "AwbNumber",
                table: "Shipments",
                newName: "ShipmentAwbNumber");

            migrationBuilder.RenameColumn(
                name: "AwbNumber",
                table: "Mawbs",
                newName: "MawbAwbNumber");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8c335bac-dd94-415a-8fcc-80f1256f6059");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b95d74f2-ae4f-482a-85ee-dbaccc63fbf4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc24589-966a-458e-8231-27692c911e99", "AQAAAAEAACcQAAAAEJb6ipTFq4LnCqVlyr7UmxMDuTP6puZwvU53gzvcQjMsJp1HiYw41Q0NnoWSgHYMDw==", "706f9775-9552-4e7d-9f07-075813dd0f58" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 75, DateTimeKind.Local).AddTicks(5817), new DateTime(2022, 1, 26, 14, 43, 57, 78, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6635), new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(729), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2571), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(6151), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7429), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3511), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3533), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3536) });
        }
    }
}
