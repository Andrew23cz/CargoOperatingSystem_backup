using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedArrival02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Arrival",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "79f2d0c9-6caa-48fe-b53c-c2fb89a07c54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1811e1f7-6953-4c38-97bb-31787adf017b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e4ed07-fab4-415c-b120-d48bdcc5b217", "AQAAAAEAACcQAAAAEHuxZ3+KcbOv0PJ+tCKJyAC1vMFKp4MimROClGXCVKDkAw23sUyItHh+vy7yjLKR9A==", "5367e58a-7399-4969-bca6-db841389a73e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 580, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 1, 2, 14, 0, 39, 582, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7184), new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(1115), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(6823), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8167), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4354), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Arrival",
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
                value: "cf12ef9e-5328-4049-8943-36b789887fdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ea601956-fefa-4ff9-abcd-504e5a600430");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd527d62-04e0-457b-a9d8-5812c167b2fe", "AQAAAAEAACcQAAAAEMRvagk+jiKo99B7Ssw19u+p2jRAi70jAyGUNOYlAIKiloMNjHopHm1BisKxv7sdjg==", "bce93853-77b7-483a-9e61-a2d758824040" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 797, DateTimeKind.Local).AddTicks(4771), new DateTime(2022, 1, 2, 11, 56, 20, 800, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(8264), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(205), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5216), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(9195), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
