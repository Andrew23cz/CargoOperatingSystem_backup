using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class DimmensionModelUpdate : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "2b752576-4f7a-47fe-924b-3f5c2e5d398a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d7773b9c-9e6a-4fb1-ad67-71e021b4a874");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a828168a-dfb5-4ce5-943d-70c5a3793c54", "AQAAAAEAACcQAAAAEOUd1KPB/qOvDSH/R2xu/RdbWZuT5r3MI7Rx2lZbAL9HIma8Day0scOPYpIkl5uP8A==", "5d84d500-54cf-4713-8b8a-01fef5476969" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82246962-e6ab-4f80-957d-daa6fb83b4fa", "AQAAAAEAACcQAAAAEEbDhIuFyLdT9FXaXV9/I8n4iTHvVXGOfvPpK+meYJjmGRU8fesmydcvbufi1QB85w==", "f0cbc237-09e6-4c4e-b2d5-74556d46d666" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 292, DateTimeKind.Local).AddTicks(3978), new DateTime(2022, 4, 9, 10, 46, 18, 295, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(7341), new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(9306), new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 4, 9, 10, 46, 18, 296, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(4279), new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(8073), new DateTime(2022, 4, 9, 10, 46, 18, 297, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 298, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 4, 9, 10, 46, 18, 298, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 46, 18, 298, DateTimeKind.Local).AddTicks(136), new DateTime(2022, 4, 9, 10, 46, 18, 298, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.AddForeignKey(
                name: "FK_Dimmension_Shipments_ShipmentId",
                table: "Dimmension",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
