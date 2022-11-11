using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ImplementedArrivalAndUpdatedOrderDeliveryInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Suppliers_SupplierId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_OrderId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SupplierId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Orders",
                newName: "OrderAmount");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Invoices",
                newName: "InvoiceAmount");

            migrationBuilder.RenameColumn(
                name: "DeliveryPoint",
                table: "Deliveries",
                newName: "OriginCode");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Deliveries",
                newName: "OffloadDate");

            migrationBuilder.RenameColumn(
                name: "CarColour",
                table: "Deliveries",
                newName: "OffloadAddress");

            migrationBuilder.AddColumn<decimal>(
                name: "DeliveryAmount",
                table: "Deliveries",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "DestCode",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadAddress",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadDate",
                table: "Deliveries",
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
                value: "de529523-01f7-4aa8-b7e9-c73f6b285930");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "33dc0898-33db-4d99-99dd-ebae483d9eee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140bab50-604c-4edf-92c0-29f72892434d", "AQAAAAEAACcQAAAAECkH4sxEhy2SJOz+271ncCYqH/KPW0uDh77vc6EhHjfDlmM/aiKdgJOPtpoYQ5gIIQ==", "4ee4a732-1d39-42b8-b114-448bf9d892aa" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 521, DateTimeKind.Local).AddTicks(5911), new DateTime(2021, 12, 29, 11, 20, 38, 524, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1875), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(5956), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8013), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8036), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(1611), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2938), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(6688), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8776), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8798), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8801) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_OrderId",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "DeliveryAmount",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "DestCode",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LoadAddress",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LoadDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Deliveries");

            migrationBuilder.RenameColumn(
                name: "OrderAmount",
                table: "Orders",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "InvoiceAmount",
                table: "Invoices",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "OriginCode",
                table: "Deliveries",
                newName: "DeliveryPoint");

            migrationBuilder.RenameColumn(
                name: "OffloadDate",
                table: "Deliveries",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "OffloadAddress",
                table: "Deliveries",
                newName: "CarColour");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Orders",
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
                name: "IX_Shipments_OrderId",
                table: "Shipments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SupplierId",
                table: "Orders",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Suppliers_SupplierId",
                table: "Orders",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Orders_OrderId",
                table: "Shipments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
