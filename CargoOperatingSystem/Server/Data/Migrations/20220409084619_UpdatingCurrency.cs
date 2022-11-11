using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Charges",
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
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Charges",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c913cebb-afa8-44ca-9c36-95a2a0f5fa42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "82f136a7-97f6-4022-a876-20f63af2d1ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58881432-7f38-49f3-9d32-2d3bb505c6a4", "AQAAAAEAACcQAAAAEC0o0ckMGjODVXDMPqAseE1/TwBg24XCH3obJfK7A2nn8AaTa9+XlTEOy63WYf/8Sg==", "a892238c-f5ce-4e7f-857b-180aa39f4e99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b85f1d2c-22ac-4533-ab51-ce50b3718041", "AQAAAAEAACcQAAAAEISe3C15kvTduqeQS6wAw49uXlXrZ/6Q4rjmIhNNkg9v+vU7ry32NCi/3cofQUj23g==", "b20b89a5-f4c6-4ddd-af50-dbce9b9296f3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 281, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 4, 9, 8, 36, 8, 284, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1451), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1542), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7321), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.AddForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
