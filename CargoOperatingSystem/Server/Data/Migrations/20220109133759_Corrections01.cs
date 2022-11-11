using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class Corrections01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "AwbStock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShipmentId1",
                table: "AwbStock",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "e4e250b4-170e-447d-8739-b2d5e221f73b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f170b199-e931-4c8e-8a54-7c07eeb39bbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9442502d-04cf-490a-acca-979fc4e9f331", "AQAAAAEAACcQAAAAEOBWh7QdDjuhhUbGlYvKUi4gQjt0qMtgqOYrvRwHOOa6E3YCUXElHMVrbTQLTqbc4w==", "7c06fe18-10bf-490a-aa53-7d14a71b0378" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 577, DateTimeKind.Local).AddTicks(4755), new DateTime(2022, 1, 9, 14, 37, 58, 579, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9275), new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(3363), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5101), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(8577), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(3526), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5717), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_ShipmentId1",
                table: "AwbStock",
                column: "ShipmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId1",
                table: "AwbStock",
                column: "ShipmentId1",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Shipments_ShipmentId1",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_ShipmentId1",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "ShipmentId1",
                table: "AwbStock");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "30e466de-c879-4c9f-a085-a5f8c5482d78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "23b49817-2cbd-4e59-b4cd-1fc67307348e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c83bd518-e41e-4ea1-914f-4b5e56bdeb0b", "AQAAAAEAACcQAAAAEE6rThnCCfnJIP8DD6ldQ72YK+GzbdCkMCrf6mIQu6SLp6EcjeDNtSckarIE1FJSxA==", "55cb19d3-91fe-4739-8374-e58950f90be3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 292, DateTimeKind.Local).AddTicks(8809), new DateTime(2022, 1, 9, 14, 24, 36, 295, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(3699), new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(7518), new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(9231), new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(9252), new DateTime(2022, 1, 9, 14, 24, 36, 296, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(2608), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(3984), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(4004), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(7728), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 1, 9, 14, 24, 36, 297, DateTimeKind.Local).AddTicks(9755) });
        }
    }
}
