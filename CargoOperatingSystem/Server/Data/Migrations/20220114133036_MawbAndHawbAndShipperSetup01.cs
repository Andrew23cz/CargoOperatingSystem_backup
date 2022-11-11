using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class MawbAndHawbAndShipperSetup01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Hawbs_HawbId",
                table: "Shippers");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Mawbs_MawbId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_HawbId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_MawbId",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "HawbId",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shippers");

            migrationBuilder.AddColumn<int>(
                name: "ShipperId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShipperId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "18475dd5-71ff-4521-aaba-9a72ac1cbdfe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1af16131-b99a-4d68-b2ad-6dda5e7a8ba9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d6b356-8950-441d-88d0-21a75b370574", "AQAAAAEAACcQAAAAEJWSnBEUW1CS8KF4iQtv7nOLPym3U42knovFe4z1Zu2mo3jEOBkeckE+20c53Yk+ZA==", "cf3a62ae-326c-4dc5-b5f7-c47f9e52981a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 331, DateTimeKind.Local).AddTicks(641), new DateTime(2022, 1, 14, 14, 30, 35, 343, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(2384), new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(2515), new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(7820), new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(9943), new DateTime(2022, 1, 14, 14, 30, 35, 345, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(6101), new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(7658), new DateTime(2022, 1, 14, 14, 30, 35, 346, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(3077), new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(5417), new DateTime(2022, 1, 14, 14, 30, 35, 347, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipperId",
                table: "Mawbs",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_ShipperId",
                table: "Hawbs",
                column: "ShipperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Shippers_ShipperId",
                table: "Hawbs",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shippers_ShipperId",
                table: "Mawbs",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Shippers_ShipperId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shippers_ShipperId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipperId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_ShipperId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Hawbs");

            migrationBuilder.AddColumn<int>(
                name: "HawbId",
                table: "Shippers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Shippers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "40c50bbd-1c8e-4fd7-bace-48d2a7f45bbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "57e544ff-ab99-4945-9bbb-07aada6bf28b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d089f5b-e35e-445f-ad69-1965d77fce2e", "AQAAAAEAACcQAAAAEFtFVaYgo3dsUz4uVFRnYaqgMRjzIGt0iw4JlJLm3TIo5zVLRnBFaglMYgXcdUZdyA==", "8277dd28-9528-45a1-a543-7fdc581178a2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 638, DateTimeKind.Local).AddTicks(3663), new DateTime(2022, 1, 14, 13, 17, 54, 650, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5989), new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 654, DateTimeKind.Local).AddTicks(7609), new DateTime(2022, 1, 14, 13, 17, 54, 654, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 657, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 1, 14, 13, 17, 54, 657, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(222), new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_HawbId",
                table: "Shippers",
                column: "HawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_MawbId",
                table: "Shippers",
                column: "MawbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Hawbs_HawbId",
                table: "Shippers",
                column: "HawbId",
                principalTable: "Hawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Mawbs_MawbId",
                table: "Shippers",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
