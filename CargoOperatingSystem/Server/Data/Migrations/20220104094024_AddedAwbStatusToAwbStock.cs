using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedAwbStatusToAwbStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AwbStatus",
                table: "AwbStock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ad67f7e8-6c65-4b19-8ba8-6086e839e569");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5b3e7ed9-d6e3-476f-a8a1-20fd23dec184");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e77ad7cd-d46d-4562-aae5-c9f5c5a9a45d", "AQAAAAEAACcQAAAAEHzXatataXtYmwfQbJefmh5FUO43xWxjLLAKxLw1wT01c6oydNGESXgf0cAylqkFRA==", "4ff3e238-8613-49cd-b7b2-7160219c12a9" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 292, DateTimeKind.Local).AddTicks(7688), new DateTime(2022, 1, 4, 10, 40, 22, 305, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 306, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 1, 4, 10, 40, 22, 306, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 306, DateTimeKind.Local).AddTicks(7144), new DateTime(2022, 1, 4, 10, 40, 22, 306, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 307, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 1, 4, 10, 40, 22, 307, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(94), new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(8067), new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(8094), new DateTime(2022, 1, 4, 10, 40, 22, 308, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 309, DateTimeKind.Local).AddTicks(7909), new DateTime(2022, 1, 4, 10, 40, 22, 309, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 310, DateTimeKind.Local).AddTicks(3896), new DateTime(2022, 1, 4, 10, 40, 22, 310, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 40, 22, 310, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 1, 4, 10, 40, 22, 310, DateTimeKind.Local).AddTicks(3964) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbStatus",
                table: "AwbStock");

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
    }
}
