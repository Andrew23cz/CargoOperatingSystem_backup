using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedDeliveryAndOrderDomainClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierType",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "Deliveries",
                type: "nvarchar(max)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Deliveries_DeliveryId",
                table: "Suppliers",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Deliveries_DeliveryId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_DeliveryId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "SupplierType",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "Deliveries");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1c90d861-27de-49d7-90f9-178f0577cd10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "798d55e5-0531-42f1-98f3-b900d4760cbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece93f5c-373a-40df-a6a5-95e16c111cff", "AQAAAAEAACcQAAAAEDxQ2rm4Y3ILjkEBSUmNv71+6uS9YA1cEaHk+tPJTmJvizNsbQlTOrCyjgzBeJtudw==", "303c6b86-bc69-4210-a87f-bcd9993036b7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 462, DateTimeKind.Local).AddTicks(1793), new DateTime(2021, 12, 29, 8, 59, 56, 464, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 465, DateTimeKind.Local).AddTicks(6828), new DateTime(2021, 12, 29, 8, 59, 56, 465, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 465, DateTimeKind.Local).AddTicks(6920), new DateTime(2021, 12, 29, 8, 59, 56, 465, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(775), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(2709), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(2731), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(6340), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(7673), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(7694), new DateTime(2021, 12, 29, 8, 59, 56, 466, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(1616), new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(3595), new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(3616), new DateTime(2021, 12, 29, 8, 59, 56, 467, DateTimeKind.Local).AddTicks(3619) });
        }
    }
}
