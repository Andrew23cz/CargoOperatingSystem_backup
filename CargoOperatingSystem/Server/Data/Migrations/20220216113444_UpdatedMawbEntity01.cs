using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbEntity01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CcChgsInDestCurrency",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChgsAtDest",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuCoRates",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCcChgs",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "2438c8ea-3100-494e-b54a-8a48c6d4b940");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c54a4a8-3065-43fe-b0c5-a698d4c9d778");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfebd7cb-2838-4863-a859-2483bd093ff2", "AQAAAAEAACcQAAAAEN9HZgrC6Wavsd9t2jCUZM4VuI7DjYDL5MOyON+243oSh12sWMggn+W4zfX23mBK9g==", "bb1278f1-6326-4df6-a581-26ba034a4f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52fdce1b-04e1-45c1-99ca-2e74621f3b73", "AQAAAAEAACcQAAAAECgXcF5mx7qp5D8GD0k7u+/mV3f1of1MVeimvV9271UmcpPMybsPEBC5CMkrcAYhMA==", "248fd8d3-35eb-4ab6-9442-fafd12eeb171" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 213, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 2, 16, 12, 34, 43, 215, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(355), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(447), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1072), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6940) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CcChgsInDestCurrency",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChgsAtDest",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CuCoRates",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalCcChgs",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "716f5702-56bc-408f-a533-ca518987c1e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "123556dc-9f67-441e-b300-e632e1724a2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0cbc80a-437b-4c82-815a-27f29b76275f", "AQAAAAEAACcQAAAAED+lt62ugtnwskf3uM8htIUHZx7Yd999rHxTPuPzrdxBmkn05qrFQD84VYrRl98wrw==", "cae33c1a-6756-4f67-9af4-f061edeb57ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8635a66d-d943-4cf6-8345-e2900be9d735", "AQAAAAEAACcQAAAAEBXK+wzv5v9NyQjF/z5iSKxeI/7JWmI1ZoAVAJHs3slT8iIt6h1NMS2hILx/K7Qa5Q==", "856bdc92-f12e-4bfc-a1c6-665061cfc559" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 163, DateTimeKind.Local).AddTicks(835), new DateTime(2022, 2, 16, 10, 51, 16, 165, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(4539), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6541), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6544) });
        }
    }
}
