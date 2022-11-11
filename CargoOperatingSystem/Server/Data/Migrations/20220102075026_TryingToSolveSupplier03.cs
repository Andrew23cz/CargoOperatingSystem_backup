using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class TryingToSolveSupplier03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "4de7e38c-e4f0-48a8-b414-ca45c180fb8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0b102fbe-f089-4fc5-b586-6bfd70bea463");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22eba6f7-3efc-4f94-a6b3-a8a5008c9827", "AQAAAAEAACcQAAAAEJCpkmHjUIh2zoJwjfWO4LJJC5x8uhZpAjzytLKKg7f79zdU/ud0+vQb/QTOtF1JSg==", "86a80268-7fe2-4a4a-af74-2e80bdf18093" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 698, DateTimeKind.Local).AddTicks(9507), new DateTime(2022, 1, 2, 8, 50, 25, 701, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(217), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6036), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6056), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1197), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(5225), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(5241), 123456789 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7159), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7171), 222333444 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7178), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7181), 555777999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
