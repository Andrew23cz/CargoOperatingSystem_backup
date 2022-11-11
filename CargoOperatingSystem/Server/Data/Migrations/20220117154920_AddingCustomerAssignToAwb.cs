using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddingCustomerAssignToAwb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "80d8e631-03f6-4003-90c1-b56b2d0e9ee5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c1941faa-3308-42ee-b025-411a692f31ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7f221b8-85f6-4b8d-9047-aec0eccee5aa", "AQAAAAEAACcQAAAAEGTdC6MXId3pY2IngmqaH0xG3kTNqAdJ/WgBHUQUFC8f3WfUEtFSEgMB29bNWUD66g==", "7bdb772f-d69f-41c2-8385-0ea159af568d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 607, DateTimeKind.Local).AddTicks(9495), new DateTime(2022, 1, 17, 16, 49, 19, 610, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 611, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 1, 17, 16, 49, 19, 611, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 611, DateTimeKind.Local).AddTicks(5993), new DateTime(2022, 1, 17, 16, 49, 19, 611, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 611, DateTimeKind.Local).AddTicks(9998), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(1790), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(1812), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(6279), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(7752), new DateTime(2022, 1, 17, 16, 49, 19, 612, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(1668), new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(3838), new DateTime(2022, 1, 17, 16, 49, 19, 613, DateTimeKind.Local).AddTicks(3840) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "98e0fbfa-be1b-432a-87a3-6aaa000e08cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b7cde989-4b2f-4d26-8d76-979789b178ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2df954e-3097-4e6e-9e84-9a661c742cf6", "AQAAAAEAACcQAAAAEBoAnt8WZZ9Lpb+AvrAQnHdbdOooLVGd+W9P4m5a7991tOYK38RoZhJ590E+QlfPnA==", "94d6ad88-c1f7-45e0-9966-dabca79f918c" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 407, DateTimeKind.Local).AddTicks(7988), new DateTime(2022, 1, 17, 14, 36, 15, 410, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5081), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 17, 14, 36, 15, 411, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(877), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(4458), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5867), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 1, 17, 14, 36, 15, 412, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(2005), new DateTime(2022, 1, 17, 14, 36, 15, 413, DateTimeKind.Local).AddTicks(2008) });
        }
    }
}
