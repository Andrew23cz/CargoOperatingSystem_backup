using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class Corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwbCount",
                table: "AwbStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbCount",
                table: "AwbStock");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c87237e1-6c8d-4fc4-98c5-e43ae94570a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "3d7d5dc7-0ba2-4de4-8e3d-a2a040597f71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3915313-e7c7-4531-84c8-781e35019dae", "AQAAAAEAACcQAAAAEFqe6R2/UHso6rJCYT6tl4VtKV7ttHkKRCWpBpYDfzSU0P2j2Hi2QJiSHfRr7E4jcw==", "1ae6adc7-948a-4104-b936-1e73db162433" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 235, DateTimeKind.Local).AddTicks(9850), new DateTime(2022, 1, 9, 10, 58, 3, 238, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4689), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4778), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(544), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5459), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1362), new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1384), new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1387) });
        }
    }
}
