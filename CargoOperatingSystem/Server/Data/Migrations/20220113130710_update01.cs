using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class update01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Hawbs");

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
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
                value: "badff4bc-25a0-4410-8092-a0c45b8cddfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "876938e1-6680-41da-b0e1-30c34cc3310f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328d5489-480b-4112-9589-edb467bf9dec", "AQAAAAEAACcQAAAAEPXf7/sSYHgVzBn4m5jk9D9GgGQSWAD95Vfj6DQk5+kdMupRxf6J4UhNxiSPT9Vd/A==", "d6a1bc53-48d4-421a-a2fb-ddf482aced18" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 716, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 1, 13, 14, 7, 9, 728, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 729, DateTimeKind.Local).AddTicks(9823), new DateTime(2022, 1, 13, 14, 7, 9, 729, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8822), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 732, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 1, 13, 14, 7, 9, 732, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "71b09ec5-9b68-4c45-8c64-8d1b5e34b0e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "79d29c8a-371a-4410-a9c2-9ff8f073895c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c25e474e-56dc-443f-ab35-9dd62108bf96", "AQAAAAEAACcQAAAAEJ2NHGj1Wh3WJ0q4/Eaao5meZEh+sMfhzNN/J0pUSatb8fgEJGDy2qVpohkzvJdxLQ==", "1d4ae6ee-963b-4fe3-bce0-7b055fa38a38" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 260, DateTimeKind.Local).AddTicks(1032), new DateTime(2022, 1, 13, 9, 0, 0, 275, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5708), new DateTime(2022, 1, 13, 9, 0, 0, 277, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8817), new DateTime(2022, 1, 13, 9, 0, 0, 278, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 279, DateTimeKind.Local).AddTicks(9407), new DateTime(2022, 1, 13, 9, 0, 0, 279, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1787), new DateTime(2022, 1, 13, 9, 0, 0, 280, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(4216), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 1, 13, 9, 0, 0, 281, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
