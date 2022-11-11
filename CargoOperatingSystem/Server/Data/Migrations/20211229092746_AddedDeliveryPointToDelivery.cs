using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedDeliveryPointToDelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Deliveries_DeliveryId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_DeliveryId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Suppliers");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryPoint",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Deliveries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1aee0960-7766-4e2a-b3a0-b86f90d26565");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d4baa826-1342-4042-92ef-8da185f30645");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255baed5-d759-4293-8adf-e4800ebd3536", "AQAAAAEAACcQAAAAEKpucB14TCkWNY+B13Rv/3tfj4wW2AoynCEjedOJ9VhgAkUdbYCjb0pHq2fZfcskCQ==", "8f63cdb6-9e56-4595-9571-0ac9cc47f686" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 37, DateTimeKind.Local).AddTicks(721), new DateTime(2021, 12, 29, 10, 27, 46, 39, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 40, DateTimeKind.Local).AddTicks(6248), new DateTime(2021, 12, 29, 10, 27, 46, 40, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 40, DateTimeKind.Local).AddTicks(6340), new DateTime(2021, 12, 29, 10, 27, 46, 40, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(205), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(1974), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(1996), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(5475), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(6954), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(6975), new DateTime(2021, 12, 29, 10, 27, 46, 41, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(876), new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(2841), new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 12, 29, 10, 27, 46, 42, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_SupplierId",
                table: "Deliveries",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Suppliers_SupplierId",
                table: "Deliveries",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Suppliers_SupplierId",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_SupplierId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "DeliveryPoint",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Deliveries");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ab8c1f20-2048-4fe5-b654-99f01ec9c157");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d769514e-3c6a-41f5-9c0c-77db62b655eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ab0e4d4-daa9-405c-9853-bae85082b160", "AQAAAAEAACcQAAAAED/o1d48ikRx9bEj1TLKpEDWgLeHYMYnEp2dc5KTtOmJAnBIWfQIJlKffa/mvyzbkw==", "afe90fbf-237f-4066-b6c5-4f591b463a94" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 405, DateTimeKind.Local).AddTicks(1872), new DateTime(2021, 12, 29, 9, 37, 55, 407, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 408, DateTimeKind.Local).AddTicks(9081), new DateTime(2021, 12, 29, 9, 37, 55, 408, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 408, DateTimeKind.Local).AddTicks(9181), new DateTime(2021, 12, 29, 9, 37, 55, 408, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(3292), new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(5264), new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(5377), new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(8822), new DateTime(2021, 12, 29, 9, 37, 55, 409, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(241), new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(262), new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(4155), new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(6594), new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(6616), new DateTime(2021, 12, 29, 9, 37, 55, 410, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DeliveryId",
                table: "Suppliers",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Deliveries_DeliveryId",
                table: "Suppliers",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
