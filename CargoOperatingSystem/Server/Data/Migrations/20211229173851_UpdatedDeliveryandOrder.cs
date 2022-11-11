using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedDeliveryandOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_OrderId",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LoadAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LoadDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OffloadAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OffloadDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Deliveries");

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a167c300-8397-4f14-b2bb-91a2a1f8f27f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a3c0dfa5-8843-43bf-85f6-279841dbea27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1758914c-16ef-4bae-a143-6a61ada7551e", "AQAAAAEAACcQAAAAEJuluMTowoamu8DJfgL3ddFTqa2eKMHlFJzKNpnSXGgr8ETWtCuV0gU6ggO7aMDgPw==", "8e78953e-6ca9-4889-a499-5b772ed0cf0b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 23, DateTimeKind.Local).AddTicks(42), new DateTime(2021, 12, 29, 18, 38, 51, 25, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9660), new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9752), new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(3651), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5511), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5534), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(9115), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(437), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(457), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(4386), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6518), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6540), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6542) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Deliveries");

            migrationBuilder.AddColumn<string>(
                name: "LoadAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OffloadAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OffloadDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Deliveries",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "94551831-10cc-46ed-a7bb-f89da8ad5c9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "541a39f5-8d0a-4753-a5b2-bbd7cdcd1b02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3891b8e8-2e62-418d-ac9c-d11b76f27900", "AQAAAAEAACcQAAAAEJhEP0YFaqOLvosnnpRZzZYCQiXbImdTiMzA0kCQGpTHUUFQlTpJ9nY+edIa1xrKsw==", "7f8ba8ec-dfe8-46fc-8a0e-3cb8ada49ba6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 549, DateTimeKind.Local).AddTicks(8683), new DateTime(2021, 12, 29, 14, 11, 41, 552, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3802), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3897), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(7800), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9631), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9652), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(3038), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4302), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4321), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(7966), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(177), new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(199), new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_OrderId",
                table: "Deliveries",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
