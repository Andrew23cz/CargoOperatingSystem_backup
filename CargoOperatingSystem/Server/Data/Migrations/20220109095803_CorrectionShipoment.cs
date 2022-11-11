using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class CorrectionShipoment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments");

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
                value: "c87237e1-6c8d-4fc4-98c5-e43ae94570a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "3d7d5dc7-0ba2-4de4-8e3d-a2a040597f71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3915313-e7c7-4531-84c8-781e35019dae", "AQAAAAEAACcQAAAAEFqe6R2/UHso6rJCYT6tl4VtKV7ttHkKRCWpBpYDfzSU0P2j2Hi2QJiSHfRr7E4jcw==", "1ae6adc7-948a-4104-b936-1e73db162433" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 235, DateTimeKind.Local).AddTicks(9850), new DateTime(2022, 1, 9, 10, 58, 3, 238, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4689), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4778), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 1, 9, 10, 58, 3, 239, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(544), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5459), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 1, 9, 10, 58, 3, 240, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1362), new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1384), new DateTime(2022, 1, 9, 10, 58, 3, 241, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Shipments",
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
                value: "1a2ab569-b14c-431b-8e35-d4bbf93de7c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e057aabe-2994-4f9b-8e94-7f8d620946c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e5292c-2744-46e5-a42c-792f27d77aa0", "AQAAAAEAACcQAAAAELQYJND8CpUZekCLOcO67wIbPve+CqoFao3lU5aKN9VcFMb84d6oAdW7WmDEd8TgzA==", "e83ae2dc-31e1-425c-92f5-67d3493bbacb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 886, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 1, 9, 10, 23, 5, 888, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8251), new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5395), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5416), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Customers_CustomerId",
                table: "Shipments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
