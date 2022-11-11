using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateHomeDb13JAN22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "d1bfb153-781c-4c11-a508-b62efe69c5c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "85919862-9270-4475-8a54-8b3a820f3ad3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8206267e-38e6-4105-a92c-097e989fe408", "AQAAAAEAACcQAAAAEJ0AIBsKtz4vJCbexmzmKwmc26q86vDUwmXYvmKcAJZ5OYFPS0RpwjRevWlwYjOo3Q==", "d6e407e1-afb8-4216-8507-c295bd4a3753" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 403, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 1, 13, 19, 54, 19, 406, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 407, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 1, 13, 19, 54, 19, 407, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 407, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 1, 13, 19, 54, 19, 407, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(3652), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(3673), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(7315), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(8605), new DateTime(2022, 1, 13, 19, 54, 19, 408, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(2442), new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 1, 13, 19, 54, 19, 409, DateTimeKind.Local).AddTicks(4573) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
