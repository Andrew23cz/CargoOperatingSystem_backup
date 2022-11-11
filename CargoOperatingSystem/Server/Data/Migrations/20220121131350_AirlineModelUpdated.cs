using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AirlineModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Airline",
                newName: "AwbHeaderB");

            migrationBuilder.AddColumn<string>(
                name: "AwbHeaderA",
                table: "Airline",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4e1cf942-6124-42f1-9e6c-87a4f484a5db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ee4db53c-b84c-4e04-a59e-71d8ab952328");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26ce2fd4-92f1-48e5-9a6b-322dc77c9e67", "AQAAAAEAACcQAAAAEAcGqneglT3eUJYno/OodkhNfw9DLq87Bvl6NdxHB4J6lYdtq9CMEMB6/RXfxBlCIA==", "69f083aa-5d4b-4fe6-b6fc-bc0d95842a47" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 307, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 1, 21, 14, 13, 48, 328, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9883), new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 333, DateTimeKind.Local).AddTicks(9861), new DateTime(2022, 1, 21, 14, 13, 48, 333, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4846), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 336, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 1, 21, 14, 13, 48, 336, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2461), new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2535), new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2541) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbHeaderA",
                table: "Airline");

            migrationBuilder.RenameColumn(
                name: "AwbHeaderB",
                table: "Airline",
                newName: "Header");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "6ccc3313-3548-408d-b1e1-61e97a8f345e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "89a176c3-9b4f-4370-a9c7-142623099a92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e51618e-7e68-4639-b91c-28f4fe00b46d", "AQAAAAEAACcQAAAAEIDYp0+HhvZMoBnOiVEQCFRHNff335uLf4ZEL5TwjrvXhZbnsvW/PLjoBfqtr4MNUQ==", "0e40c40b-c51e-4702-bcd2-5998e7b03a6b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 862, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 21, 12, 54, 0, 930, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 934, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 1, 21, 12, 54, 0, 934, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(5957), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9354), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9416), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 940, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 1, 21, 12, 54, 0, 940, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4122), new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4191) });
        }
    }
}
