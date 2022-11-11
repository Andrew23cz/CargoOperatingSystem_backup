using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class TrySolveSupplier02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Suppliers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c84023ee-c924-49c7-9037-3271ad32f53b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "cd9272ab-2756-4937-a899-90b8e04bb69e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eccc5d63-e980-4238-a75d-8c2711da0c03", "AQAAAAEAACcQAAAAELxzORaUdzC3ChwRP1892QqblBa705hhdOhdV4884O6Y5JlIdEDdXnmONQKFJanvlQ==", "696bab8a-fc62-4b08-8944-49034eba6cdc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 497, DateTimeKind.Local).AddTicks(9215), new DateTime(2022, 1, 1, 11, 48, 29, 500, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(4939), new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(5033), new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 1, 1, 11, 48, 29, 501, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(1107), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(5994), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(6014), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(9676), new DateTime(2022, 1, 1, 11, 48, 29, 502, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 503, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 1, 1, 11, 48, 29, 503, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 48, 29, 503, DateTimeKind.Local).AddTicks(1449), new DateTime(2022, 1, 1, 11, 48, 29, 503, DateTimeKind.Local).AddTicks(1452) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "e986da29-a594-418e-a279-6d9b9c5b8cde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9671a95a-fa4b-477c-845f-3e78d0467853");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83a3b075-0a10-4f17-af51-0fd437226860", "AQAAAAEAACcQAAAAEHXzYOFJJ3sC298Tk4TQBdyaAgoMGESByH8bHkogxkuTBh32PIrTu6W8+KluxoF8kA==", "3fe98395-d4fb-47b5-bbc0-697d07cf068e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 993, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 1, 1, 11, 41, 8, 996, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1004), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1094), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(4858), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1583), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1604), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(5612), 603236639 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7592), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7606), 555666789 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7617), 606485926 });
        }
    }
}
