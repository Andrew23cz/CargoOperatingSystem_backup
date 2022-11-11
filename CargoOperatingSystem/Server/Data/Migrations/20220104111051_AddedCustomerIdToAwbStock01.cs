using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedCustomerIdToAwbStock01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "93471b3e-5b0e-4254-a4d2-b4fc2ea4edbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "527f2937-e5f1-4efe-bea6-3379c806c327");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bad85a4-77ce-4b16-9f63-77a675bca4c8", "AQAAAAEAACcQAAAAELzNcC3pk/76m+PpO7Q/8S7SGYnjzVTQWipHJvcc1UHTP5BFTWUNad2m27DcXhDwEA==", "6d8728d6-02bc-4d35-8d73-5a3a35dd7d89" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 33, DateTimeKind.Local).AddTicks(6352), new DateTime(2022, 1, 4, 12, 10, 50, 46, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2570), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 1, 4, 12, 10, 50, 48, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1681), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(8795), new DateTime(2022, 1, 4, 12, 10, 50, 49, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(737), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 1, 4, 12, 10, 50, 50, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5100), new DateTime(2022, 1, 4, 12, 10, 50, 51, DateTimeKind.Local).AddTicks(5104) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "33daa822-1096-42e5-bf07-fa4ca14f00f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e3ccf6e4-29ac-4345-a7f5-edcc65efed60");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa50790-db44-4791-9b6b-449b99fe9a4b", "AQAAAAEAACcQAAAAEOeAaEgqMluzxRG81sAmOCgvjwX06b63Ms7PJOreqKgWe/imkR+X0Sy7rYvaDhne2A==", "a5d06816-6a7d-4f07-840b-8d5b13e5c850" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 718, DateTimeKind.Local).AddTicks(49), new DateTime(2022, 1, 4, 10, 56, 15, 731, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 735, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 1, 4, 10, 56, 15, 735, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 735, DateTimeKind.Local).AddTicks(7174), new DateTime(2022, 1, 4, 10, 56, 15, 735, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 736, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 1, 4, 10, 56, 15, 736, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 737, DateTimeKind.Local).AddTicks(3741), new DateTime(2022, 1, 4, 10, 56, 15, 737, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 737, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 1, 4, 10, 56, 15, 737, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(8707), new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(8779), new DateTime(2022, 1, 4, 10, 56, 15, 738, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(667), new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(5569), new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 1, 4, 10, 56, 15, 740, DateTimeKind.Local).AddTicks(5647) });
        }
    }
}
