using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AwbStockAndShipmentRelationshipUpdate03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "51306470-4b60-46d3-b380-ab2d83821607");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "bb496ba9-656b-44d0-888e-ad1e42cf6510");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "754ac5a3-36f0-465c-aeb2-64cc7cd00f9d", "AQAAAAEAACcQAAAAEE1KDWfZGbkVw222GeEocO0Mjt/t0F8IPdY/l+Jkq2bzlnbEftGSJlnsvWu71Dd3Og==", "fb005860-32a5-4fc6-bb8b-f439885b4805" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 841, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 1, 11, 19, 43, 13, 843, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6404), new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 1, 11, 19, 43, 13, 844, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 1, 11, 19, 43, 13, 845, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(786), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 1, 11, 19, 43, 13, 846, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "944ab3b8-a25e-4a06-89cc-95bb9fe50484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b4a849fa-5909-42b1-be8e-4414ef94109b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69db03e0-9663-47ae-b62b-128767fb5ef6", "AQAAAAEAACcQAAAAED3rL7Nf2GsBMHZ7mYAUKrlvC4IDNOriZqyPHm8yGwc1k4mYrRxVR+HOKjlHKoZ9SA==", "57d7ecdc-81f6-4af3-8fda-da476c4c7d3b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 764, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 11, 19, 40, 31, 766, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8557), new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8642), new DateTime(2022, 1, 11, 19, 40, 31, 767, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9014), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9033), new DateTime(2022, 1, 11, 19, 40, 31, 768, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(2749), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 1, 11, 19, 40, 31, 769, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
