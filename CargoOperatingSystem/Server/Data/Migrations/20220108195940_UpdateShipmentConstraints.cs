using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateShipmentConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "c2f6d9a9-ea3d-46ea-906b-d425922e8fd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "77dee6bc-e3f0-4cb3-92ba-c84ea3c0917a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a014727e-4421-4e5a-b86e-3a63ce98c4c0", "AQAAAAEAACcQAAAAEL3ci33siyfHc+079kEQffmtXkePZmfFkwHtNPUf4H0EgtzRVAMWZFuPQj2jSTbbSg==", "03c4495b-b219-4929-b18c-253f781506cd" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 549, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 1, 8, 20, 59, 39, 551, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(846), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2634), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(6149), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7406), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7426), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3432) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "8aaac2c7-0e7a-4ca3-b81a-2e685d90d79b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9c1998eb-ae51-49b7-87b3-26b9d1bbbdd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7935ffe8-a2c0-4856-9662-64a81e192e41", "AQAAAAEAACcQAAAAECYrIl06lbTVXSXBZDc4HsnzqsL+L6m1fn/ydhyC/DRcrXjaBJH3EXbsIw+EraMPFw==", "5576a407-d56f-4d82-a744-4bf5c91aef29" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 234, DateTimeKind.Local).AddTicks(646), new DateTime(2022, 1, 8, 16, 34, 23, 236, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5116), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5208), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(9295), new DateTime(2022, 1, 8, 16, 34, 23, 237, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1028), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1049), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(4461), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(9712), new DateTime(2022, 1, 8, 16, 34, 23, 238, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 1, 8, 16, 34, 23, 239, DateTimeKind.Local).AddTicks(1670) });
        }
    }
}
