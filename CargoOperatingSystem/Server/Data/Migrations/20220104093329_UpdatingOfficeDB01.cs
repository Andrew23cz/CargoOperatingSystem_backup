using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingOfficeDB01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "70961dc3-a05d-46f8-a193-884c28ceb6ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d6fa6c73-9d13-4834-bc69-0860a3d80a18");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d38e99bf-7424-4555-ba2c-f4ee753764a9", "AQAAAAEAACcQAAAAELJhgf3xLVeM5ErsZno+rwpmPFBZTTjrMJs7a/Cm3NrVRZN7IF783bKOhztEdBoHiQ==", "bafd964c-3429-42ce-aa84-6d59bdeb7b36" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 100, DateTimeKind.Local).AddTicks(6838), new DateTime(2022, 1, 4, 10, 33, 27, 114, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 116, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 1, 4, 10, 33, 27, 116, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 116, DateTimeKind.Local).AddTicks(9297), new DateTime(2022, 1, 4, 10, 33, 27, 116, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 118, DateTimeKind.Local).AddTicks(5726), new DateTime(2022, 1, 4, 10, 33, 27, 118, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 119, DateTimeKind.Local).AddTicks(629), new DateTime(2022, 1, 4, 10, 33, 27, 119, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 119, DateTimeKind.Local).AddTicks(695), new DateTime(2022, 1, 4, 10, 33, 27, 119, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 120, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 1, 4, 10, 33, 27, 120, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 121, DateTimeKind.Local).AddTicks(5387), new DateTime(2022, 1, 4, 10, 33, 27, 121, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 121, DateTimeKind.Local).AddTicks(5449), new DateTime(2022, 1, 4, 10, 33, 27, 121, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(9851), new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 1, 4, 10, 33, 27, 122, DateTimeKind.Local).AddTicks(9912) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c5e7f300-3dbd-47ce-864c-d15481d59181");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0f995e80-902c-4823-afee-07087143cf99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bddc3d74-2a83-4308-836c-5fa3fda08a35", "AQAAAAEAACcQAAAAEIfSqCZLtbh+ROO3uYBYJ/ctF616A2OdrY98v1TltEMqwVzE5zVtMicMNDQCWxSsdw==", "6310678b-173c-4651-b9da-0dde90146823" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 459, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 1, 3, 19, 43, 49, 462, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5357), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1213), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(564), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2538), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2568), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2570) });
        }
    }
}
