using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ArrivalAndSupplierDependencySetup01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "0d1469b9-8ebe-4521-85b9-62fd87b31fb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "becd7193-622e-4168-98d0-891469bfde74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "672a7262-076f-4f8a-8083-ada4a6d49279", "AQAAAAEAACcQAAAAEGSvQ5xG7jBageZO7WLIIgGg7xzh009CFDEUbDgU0Tlba2TExyGYHn2qN+uZ3YkgxA==", "b0c3d973-b659-4677-834c-be293ec0c0c7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 388, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 1, 14, 12, 57, 17, 407, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 409, DateTimeKind.Local).AddTicks(8417), new DateTime(2022, 1, 14, 12, 57, 17, 409, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 409, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 1, 14, 12, 57, 17, 409, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 410, DateTimeKind.Local).AddTicks(8638), new DateTime(2022, 1, 14, 12, 57, 17, 410, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(2116), new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(2164), new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(9704), new DateTime(2022, 1, 14, 12, 57, 17, 411, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 412, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 1, 14, 12, 57, 17, 412, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 412, DateTimeKind.Local).AddTicks(1607), new DateTime(2022, 1, 14, 12, 57, 17, 412, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(4377), new DateTime(2022, 1, 14, 12, 57, 17, 413, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "dd21c2e5-d278-4988-934c-ff3ef8636592");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "74cc8842-c9ff-4c8e-aae7-61057d3aa73e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dec0bc51-c291-4006-bd06-fedf4a89a984", "AQAAAAEAACcQAAAAEBr9XFH96TOlcvwJ4RmRN4yosRgUljnFxpBS3KSHjnnK+R6qRF8Xlut8UqFc5s1wdg==", "c828b721-0f66-4d3d-87c4-f098d0077768" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 66, DateTimeKind.Local).AddTicks(7900), new DateTime(2022, 1, 13, 16, 30, 27, 78, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9028), new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(4666), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3538), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(9149), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
