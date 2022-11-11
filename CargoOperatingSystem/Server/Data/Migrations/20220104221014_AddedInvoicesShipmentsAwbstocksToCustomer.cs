using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedInvoicesShipmentsAwbstocksToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "35cbfb3f-2298-4d74-b271-faf383ad2d6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c2ecda0-a7ae-4b1f-a0b2-9ed80126d167");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362b89ef-9157-4209-87eb-e7c89403986b", "AQAAAAEAACcQAAAAECxXF1P61L8IxtBBGIg79mVZyq0N+wtUAy+HMxbS2uGlHt4D4/H1maJTfBweJbzw3A==", "b173aa20-e3d8-41d9-a895-5d57720bc887" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 708, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 1, 4, 23, 10, 13, 711, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5592), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1773), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(5421), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6865), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(879), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2971), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2996) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ab9be1e8-308b-4384-b849-35cf6cd38b35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1a8048c8-f98f-471b-a506-2da955567ce7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed6de85-cfa2-4f04-9a14-b22c4d30be24", "AQAAAAEAACcQAAAAENsIV+v0L2J9qyhyrSvhlNBIre1z9GUYvXVjmLEFQ7i2oYU/U75nHgYjdFS7I78CVA==", "403a0566-2e20-40e5-b5e6-dddf6f452c5f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 186, DateTimeKind.Local).AddTicks(7715), new DateTime(2022, 1, 4, 19, 15, 13, 189, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(2344), new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(2440), new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(6438), new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(8333), new DateTime(2022, 1, 4, 19, 15, 13, 190, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(2437), new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(3839), new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(3862), new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 1, 4, 19, 15, 13, 191, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 192, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 1, 4, 19, 15, 13, 192, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 15, 13, 192, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 1, 4, 19, 15, 13, 192, DateTimeKind.Local).AddTicks(346) });
        }
    }
}
