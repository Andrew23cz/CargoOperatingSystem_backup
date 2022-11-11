using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ShipmentBasicNumberDataSetToNotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Volume",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pieces",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GrossWeight",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ChargeableWeight",
                table: "Shipments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "98e0fbfa-be1b-432a-87a3-6aaa000e08cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b7cde989-4b2f-4d26-8d76-979789b178ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2df954e-3097-4e6e-9e84-9a661c742cf6", "AQAAAAEAACcQAAAAEBoAnt8WZZ9Lpb+AvrAQnHdbdOooLVGd+W9P4m5a7991tOYK38RoZhJ590E+QlfPnA==", "94d6ad88-c1f7-45e0-9966-dabca79f918c" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 407, DateTimeKind.Local).AddTicks(7988), new DateTime(2022, 1, 17, 14, 36, 15, 410, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5081), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(877), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(4458), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5867), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(2005), new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(2008) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Volume",
                table: "Shipments",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Pieces",
                table: "Shipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "GrossWeight",
                table: "Shipments",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "ChargeableWeight",
                table: "Shipments",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "721515e0-b729-453e-925d-06109a3904b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f7531a1f-1d89-4c20-b906-cf235c1b3ae5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c20c37fd-7364-4792-8dd3-c32d14ebc918", "AQAAAAEAACcQAAAAEHx0vgVVoZ0jyDGiZCGX4+ZlaoHRWmy8aMHCtCTGCgbn1ze4KySB7XEYgWTLHqLDTg==", "31bdeba1-92a0-48e6-b6bc-19b921ed4399" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 284, DateTimeKind.Local).AddTicks(2543), new DateTime(2022, 1, 14, 18, 50, 15, 286, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(7993), new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8085), new DateTime(2022, 1, 14, 18, 50, 15, 287, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 1, 14, 18, 50, 15, 288, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4832), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4853), new DateTime(2022, 1, 14, 18, 50, 15, 289, DateTimeKind.Local).AddTicks(4855) });
        }
    }
}
