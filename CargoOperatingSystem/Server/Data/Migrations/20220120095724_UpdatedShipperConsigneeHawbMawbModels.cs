using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedShipperConsigneeHawbMawbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Shippers",
                newName: "AddressB");

            migrationBuilder.RenameColumn(
                name: "ShipperAddress",
                table: "Mawbs",
                newName: "ShipperAddressB");

            migrationBuilder.RenameColumn(
                name: "ConsigneeAddress",
                table: "Mawbs",
                newName: "ShipperAddressA");

            migrationBuilder.RenameColumn(
                name: "ShipperAddress",
                table: "Hawbs",
                newName: "ShipperAddressB");

            migrationBuilder.RenameColumn(
                name: "ConsigneeAddress",
                table: "Hawbs",
                newName: "ShipperAddressA");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Consignees",
                newName: "AddressB");

            migrationBuilder.AddColumn<string>(
                name: "AddressA",
                table: "Shippers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAccountNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAccountNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressA",
                table: "Consignees",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "La Palma 1566, Mexico City", null, new DateTime(2022, 1, 20, 10, 57, 22, 681, DateTimeKind.Local).AddTicks(6331), new DateTime(2022, 1, 20, 10, 57, 22, 695, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "ShangriLa 255, Shanghai", null, new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "Na Kopci 15, Hradec Kralove", null, new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 1, 20, 10, 57, 22, 697, DateTimeKind.Local).AddTicks(5059) });

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
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "Aviaticka 55, Praha 6, 16000", null, new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "Industrialni 256, Ostrava, 354442", null, new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressA", "AddressB", "DateCreated", "DateUpdated" },
                values: new object[] { "K sidlist 25, Praha 6, 16200", null, new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 1, 20, 10, 57, 22, 699, DateTimeKind.Local).AddTicks(5028) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressA",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "ConsigneeAccountNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAccountNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AddressA",
                table: "Consignees");

            migrationBuilder.RenameColumn(
                name: "AddressB",
                table: "Shippers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "ShipperAddressB",
                table: "Mawbs",
                newName: "ShipperAddress");

            migrationBuilder.RenameColumn(
                name: "ShipperAddressA",
                table: "Mawbs",
                newName: "ConsigneeAddress");

            migrationBuilder.RenameColumn(
                name: "ShipperAddressB",
                table: "Hawbs",
                newName: "ShipperAddress");

            migrationBuilder.RenameColumn(
                name: "ShipperAddressA",
                table: "Hawbs",
                newName: "ConsigneeAddress");

            migrationBuilder.RenameColumn(
                name: "AddressB",
                table: "Consignees",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b0d1b9de-a1f0-47db-83ec-ff69aa80e82b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "454f2ea0-ca8b-4d7c-b6e9-0de18b61ac7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76c88626-4a88-4f78-9f84-59a9f0023ff3", "AQAAAAEAACcQAAAAEBqUU1t2G1TyeeZ1qekHFRvUIOTNrfrFH3SXBKIM1Egiq8/tnS5+VZuM5jwOCsHIQw==", "907d0a64-1952-40eb-9474-4d097c588074" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "La Palma 1566, Mexico City", new DateTime(2022, 1, 19, 19, 0, 46, 111, DateTimeKind.Local).AddTicks(7578), new DateTime(2022, 1, 19, 19, 0, 46, 114, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "ShangriLa 255, Shanghai", new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "Na Kopci 15, Hradec Kralove", new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(5023), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 1, 19, 19, 0, 46, 115, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "Aviaticka 55, Praha 6, 16000", new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "Industrialni 256, Ostrava, 354442", new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6438), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "DateCreated", "DateUpdated" },
                values: new object[] { "K sidlist 25, Praha 6, 16200", new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6459), new DateTime(2022, 1, 19, 19, 0, 46, 116, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 1, 19, 19, 0, 46, 117, DateTimeKind.Local).AddTicks(3055) });
        }
    }
}
