using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SyncAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Currency_CurrencyId",
                table: "Charges");

            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Charges",
                table: "Charges");

            migrationBuilder.RenameTable(
                name: "Charges",
                newName: "Charge");

            migrationBuilder.RenameIndex(
                name: "IX_Charges_ShipmentId",
                table: "Charge",
                newName: "IX_Charge_ShipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Charges_CurrencyId",
                table: "Charge",
                newName: "IX_Charge_CurrencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Charge",
                table: "Charge",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ff9bbf48-029d-43f3-abe7-1e5e2401f517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e03ff787-c2ff-4928-a708-ec3a62a5dbaf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eb02fcd-f73d-435c-a18a-9652f19de919", "AQAAAAEAACcQAAAAEFFDQGkjP0Hzj+soDhvNpUyt7eS5ruqJWSLktiT9stgfUrzu/UnL7zzUqiCHowqh7A==", "1ece85c3-4f9d-4bca-b192-9ed6005d3f39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a69c89a7-293a-477b-8470-d9b17b382c14", "AQAAAAEAACcQAAAAEHd1Ses1UuIbrUpGfQgWq1Wmzs2CzWtl06C5kWzDrbhXiuVYWfW0IO4atBHA9moKVA==", "17faa842-343b-4c25-a73a-5b84d473c250" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 362, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 4, 9, 17, 9, 11, 366, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7333), new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7432), new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3522), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8396), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8416), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4555), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.AddForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Charge_Shipments_ShipmentId",
                table: "Charge",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge");

            migrationBuilder.DropForeignKey(
                name: "FK_Charge_Shipments_ShipmentId",
                table: "Charge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Charge",
                table: "Charge");

            migrationBuilder.RenameTable(
                name: "Charge",
                newName: "Charges");

            migrationBuilder.RenameIndex(
                name: "IX_Charge_ShipmentId",
                table: "Charges",
                newName: "IX_Charges_ShipmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Charge_CurrencyId",
                table: "Charges",
                newName: "IX_Charges_CurrencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Charges",
                table: "Charges",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a72263dc-d45d-410b-94f5-ee18cd4c12f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "25bab109-49dc-4f10-986e-b6d7b1cf5856");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70536153-a70a-4e57-a37d-86f62d685783", "AQAAAAEAACcQAAAAEGwNZ0dFTTyhB+svLOQ5qw0z9Qkcp9rQGmgO9CUDOhSUeaDwb+d1AYXnMygs7UDUcA==", "93f3b359-9819-4937-8bd1-bb343ee841f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f50f01-494c-4e67-b58c-1b362fa2879c", "AQAAAAEAACcQAAAAEFBHdB4TwFTj9zc0fXs1wW0jWah4VxaGQdbQfdDenwyDaxKYJsTgnJmjiV46Mhb6zw==", "773c5aa2-cdc4-4ac8-b1e1-42ccf1a8958e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 320, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 4, 9, 14, 49, 21, 323, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8263), new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8369), new DateTime(2022, 4, 9, 14, 49, 21, 324, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4773), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9799), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9822), new DateTime(2022, 4, 9, 14, 49, 21, 325, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 4, 9, 14, 49, 21, 326, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.AddForeignKey(
                name: "FK_Charges_Currency_CurrencyId",
                table: "Charges",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
