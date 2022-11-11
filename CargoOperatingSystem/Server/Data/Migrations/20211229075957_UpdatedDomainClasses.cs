using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedDomainClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Shipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Shipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DuzpDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuingDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_DeliveryId",
                table: "Shipments",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Deliveries_DeliveryId",
                table: "Shipments",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Deliveries_DeliveryId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_DeliveryId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "DuzpDate",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "IssuingDate",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Shipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "41c020c8-8ebb-4ef0-944f-6333c4921828");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "142771c9-9351-4fe3-ab70-8e8a0b9d19dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "058adb82-a897-4e0d-b91a-ea290b751493", "AQAAAAEAACcQAAAAEMK61Cf8NtpfmmV1VSQunqwOv1n9UexoWGv6iyWOrspt2JXxmV/uxK+Cmk5sdXnqQA==", "6032758d-33bb-4012-ae6c-a444955af8f2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 912, DateTimeKind.Local).AddTicks(8037), new DateTime(2021, 12, 29, 8, 9, 26, 915, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3156), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3245), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(7103), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8884), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8904), new DateTime(2021, 12, 29, 8, 9, 26, 916, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(2587), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3960), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3979), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(7868), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9796), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9816), new DateTime(2021, 12, 29, 8, 9, 26, 917, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
