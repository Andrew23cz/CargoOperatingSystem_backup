using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbHawbShipperConsigneeCustomerModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShipperAccountNo",
                table: "Mawbs",
                newName: "HandlingInfoC");

            migrationBuilder.RenameColumn(
                name: "HandlingInfo",
                table: "Mawbs",
                newName: "HandlingInfoB");

            migrationBuilder.RenameColumn(
                name: "ConsigneeAccountNo",
                table: "Mawbs",
                newName: "HandlingInfoA");

            migrationBuilder.RenameColumn(
                name: "AirlineHeader",
                table: "Mawbs",
                newName: "AirlineName");

            migrationBuilder.RenameColumn(
                name: "AgentAccountNo",
                table: "Mawbs",
                newName: "AirlineAddressB");

            migrationBuilder.RenameColumn(
                name: "AccountingInfo",
                table: "Mawbs",
                newName: "AirlineAddressA");

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Mawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IataCode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "fe784d90-a250-4541-82fb-b2f509c2dc0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "3cdd5d88-3153-42e4-9fb1-7651d637e86d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "202fe533-0dc1-47f5-aab9-838bce12e93d", "AQAAAAEAACcQAAAAEIw+sbwq7IPq//uQZWrHu77X5lcndU5Fggf+yJZC0RCue7qrlzljRvrmf9jQ1b0hOQ==", "6b64e99d-6197-4f64-b42f-7f83bace1882" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 186, DateTimeKind.Local).AddTicks(3947), new DateTime(2022, 1, 20, 16, 32, 55, 232, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(7045), new DateTime(2022, 1, 20, 16, 32, 55, 234, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8360), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8396), new DateTime(2022, 1, 20, 16, 32, 55, 235, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(6241), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8374), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8407), new DateTime(2022, 1, 20, 16, 32, 55, 236, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(1640), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7009), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 1, 20, 16, 32, 55, 239, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AirlineId",
                table: "Mawbs",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_CustomerId",
                table: "Mawbs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AirlineId",
                table: "Hawbs",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_CustomerId",
                table: "Hawbs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Airline_AirlineId",
                table: "Hawbs",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Customers_CustomerId",
                table: "Hawbs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Airline_AirlineId",
                table: "Mawbs",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Customers_CustomerId",
                table: "Mawbs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Airline_AirlineId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Customers_CustomerId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Airline_AirlineId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Customers_CustomerId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AirlineId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_CustomerId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AirlineId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_CustomerId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IataCode",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "HandlingInfoC",
                table: "Mawbs",
                newName: "ShipperAccountNo");

            migrationBuilder.RenameColumn(
                name: "HandlingInfoB",
                table: "Mawbs",
                newName: "HandlingInfo");

            migrationBuilder.RenameColumn(
                name: "HandlingInfoA",
                table: "Mawbs",
                newName: "ConsigneeAccountNo");

            migrationBuilder.RenameColumn(
                name: "AirlineName",
                table: "Mawbs",
                newName: "AirlineHeader");

            migrationBuilder.RenameColumn(
                name: "AirlineAddressB",
                table: "Mawbs",
                newName: "AgentAccountNo");

            migrationBuilder.RenameColumn(
                name: "AirlineAddressA",
                table: "Mawbs",
                newName: "AccountingInfo");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "24115037-559a-4b9a-b3e8-59129f940497");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "7bde776f-65a3-4705-9024-575e2da47866");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af30feda-0dc7-4f84-b306-c8ee5101b82f", "AQAAAAEAACcQAAAAEILBZxU+x8gB3uw2zW9VeICBsLzvC0CYS5/H18zCnk26grpSY5LsFB6uK/YcDA2h5Q==", "e785a039-b4a2-4145-9e98-37154f5b2c08" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 681, DateTimeKind.Local).AddTicks(6331), new DateTime(2022, 1, 20, 10, 57, 22, 695, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(2505), new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(5986), new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(6020), new DateTime(2022, 1, 20, 10, 57, 22, 698, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(5574), new DateTime(2022, 1, 20, 10, 57, 22, 700, DateTimeKind.Local).AddTicks(5577) });
        }
    }
}
