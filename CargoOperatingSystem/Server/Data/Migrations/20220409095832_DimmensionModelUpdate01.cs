using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class DimmensionModelUpdate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimmension_Shipments_ShipmentId",
                table: "Dimmension");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Dimmension",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5fceaa30-9f70-4492-92c4-47c1467f6fe1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "988767f6-bc93-45cf-ad1b-385d9c572b00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a8b3530-50de-4ce4-a635-265c8ab96ace", "AQAAAAEAACcQAAAAEIWD9fGT6GWS2O2f1QLH7tue+v/o37bnZEqU7binaw6gtQXQpkUOLedZPP2pJtkM1A==", "380db220-afd3-4812-b490-889db0ff4f5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b45b9ee-2008-4d2f-8cb0-181ef6cff0d2", "AQAAAAEAACcQAAAAEF18HULkuVqRGtlXu4JHgCr7ZzD/LXguJdJ8xEoBqrPpWFs1DI6U8DHM1W7Qm433tg==", "3063b32d-9fa9-44aa-a127-344c5c198e54" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 559, DateTimeKind.Local).AddTicks(4135), new DateTime(2022, 4, 9, 11, 58, 31, 562, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3612), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3711), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(7781), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9532), new DateTime(2022, 4, 9, 11, 58, 31, 563, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5183), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(9036), new DateTime(2022, 4, 9, 11, 58, 31, 564, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(986), new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 4, 9, 11, 58, 31, 565, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.AddForeignKey(
                name: "FK_Dimmension_Shipments_ShipmentId",
                table: "Dimmension",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimmension_Shipments_ShipmentId",
                table: "Dimmension");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Dimmension",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "2d1e5fef-9db3-47f4-abc5-e1ae9af3ae1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c4db44a7-7e83-4981-9179-011cec6c081d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe3caa86-e2fa-4f0e-b4d4-72e72c53e3bb", "AQAAAAEAACcQAAAAEFpw8lDS9XGzWmqTkSiAB8cDPIy9VvMtftgwQ8XcC02rD++xrNxeeB8sgUoP5iCXxA==", "f7cf0495-906e-4863-9abe-f1c12863db49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1512d205-4f1d-4103-a181-5cf7922cd05e", "AQAAAAEAACcQAAAAEN9X9xphWG04XdfPIztVGPkDE6Wl5ECMGkQLkJRZi9Ap4Q+Y5M6014ioYHTCFy9hNA==", "94e61c51-4a9b-47a2-bd0d-57967cf77e26" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 222, DateTimeKind.Local).AddTicks(1208), new DateTime(2022, 4, 9, 11, 50, 41, 224, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 225, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 4, 9, 11, 50, 41, 225, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 225, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 4, 9, 11, 50, 41, 225, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(4638), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(8179), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(9469), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 4, 9, 11, 50, 41, 226, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(5277), new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(5299), new DateTime(2022, 4, 9, 11, 50, 41, 227, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.AddForeignKey(
                name: "FK_Dimmension_Shipments_ShipmentId",
                table: "Dimmension",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
