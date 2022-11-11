using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedCustomerIdToAwbStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "AwbStock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "AwbStock",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_CustomerId1",
                table: "AwbStock",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AwbStock_Customers_CustomerId1",
                table: "AwbStock",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AwbStock_Customers_CustomerId1",
                table: "AwbStock");

            migrationBuilder.DropIndex(
                name: "IX_AwbStock_CustomerId1",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "AwbStock");

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
    }
}
