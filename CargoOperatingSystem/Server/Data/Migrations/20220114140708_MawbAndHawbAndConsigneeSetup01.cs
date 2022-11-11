using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class MawbAndHawbAndConsigneeSetup01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consignees_Hawbs_HawbId",
                table: "Consignees");

            migrationBuilder.DropForeignKey(
                name: "FK_Consignees_Mawbs_MawbId",
                table: "Consignees");

            migrationBuilder.DropIndex(
                name: "IX_Consignees_HawbId",
                table: "Consignees");

            migrationBuilder.DropIndex(
                name: "IX_Consignees_MawbId",
                table: "Consignees");

            migrationBuilder.DropColumn(
                name: "HawbId",
                table: "Consignees");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Consignees");

            migrationBuilder.AddColumn<int>(
                name: "ConsigneeId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsigneeId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "23aaf49d-1b55-4131-91c2-c3ffb776cc11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8ffbdb8e-d581-49f5-8faf-fb182b1f902e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa7c3dd-f259-4e54-84d8-be70e1fad680", "AQAAAAEAACcQAAAAECuFw8CL7lE2o4BZv8mbnE9U+1WyZocFl3HBLWq2Q92SuMu9824URbA/jtBHgYMFGw==", "80b8b5c7-e119-4323-8d95-4f99091c9a4e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 266, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 1, 14, 15, 7, 7, 278, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5752), new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5912), new DateTime(2022, 1, 14, 15, 7, 7, 279, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(1824), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3963), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3989), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(9342), new DateTime(2022, 1, 14, 15, 7, 7, 280, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1143), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1169), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(5987), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8358), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8384), new DateTime(2022, 1, 14, 15, 7, 7, 281, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ConsigneeId",
                table: "Mawbs",
                column: "ConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_ConsigneeId",
                table: "Hawbs",
                column: "ConsigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Consignees_ConsigneeId",
                table: "Hawbs",
                column: "ConsigneeId",
                principalTable: "Consignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Consignees_ConsigneeId",
                table: "Mawbs",
                column: "ConsigneeId",
                principalTable: "Consignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Consignees_ConsigneeId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Consignees_ConsigneeId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ConsigneeId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_ConsigneeId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeId",
                table: "Hawbs");

            migrationBuilder.AddColumn<int>(
                name: "HawbId",
                table: "Consignees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Consignees",
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
                name: "IX_Consignees_HawbId",
                table: "Consignees",
                column: "HawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Consignees_MawbId",
                table: "Consignees",
                column: "MawbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consignees_Hawbs_HawbId",
                table: "Consignees",
                column: "HawbId",
                principalTable: "Hawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consignees_Mawbs_MawbId",
                table: "Consignees",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
