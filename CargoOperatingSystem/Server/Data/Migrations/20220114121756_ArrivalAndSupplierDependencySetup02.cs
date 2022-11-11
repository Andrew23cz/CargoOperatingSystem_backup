using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ArrivalAndSupplierDependencySetup02 : Migration
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
                value: "40c50bbd-1c8e-4fd7-bace-48d2a7f45bbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "57e544ff-ab99-4945-9bbb-07aada6bf28b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d089f5b-e35e-445f-ad69-1965d77fce2e", "AQAAAAEAACcQAAAAEFtFVaYgo3dsUz4uVFRnYaqgMRjzIGt0iw4JlJLm3TIo5zVLRnBFaglMYgXcdUZdyA==", "8277dd28-9528-45a1-a543-7fdc581178a2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 638, DateTimeKind.Local).AddTicks(3663), new DateTime(2022, 1, 14, 13, 17, 54, 650, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(5989), new DateTime(2022, 1, 14, 13, 17, 54, 653, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 654, DateTimeKind.Local).AddTicks(7609), new DateTime(2022, 1, 14, 13, 17, 54, 654, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 1, 14, 13, 17, 54, 655, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 1, 14, 13, 17, 54, 656, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 657, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 1, 14, 13, 17, 54, 657, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(222), new DateTime(2022, 1, 14, 13, 17, 54, 658, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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
    }
}
