using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedCodeToAirline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Airline",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Airline");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "18364513-3f77-476a-afb2-d657fab1dafd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "99ae1700-2ddb-4581-80eb-3c61f4ae52c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d8aded-0e9e-4c40-9976-7eccfd15f8a0", "AQAAAAEAACcQAAAAEHaWADQqCG/thkiaBu9CDBolfJ1zSIhPvP5K/hT/Tg2XSbEESyVSJt48+UQbEvvuag==", "ad644264-8b34-4438-87db-e1578e3c12cb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 361, DateTimeKind.Local).AddTicks(9071), new DateTime(2022, 1, 4, 19, 1, 54, 365, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 366, DateTimeKind.Local).AddTicks(8462), new DateTime(2022, 1, 4, 19, 1, 54, 366, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 366, DateTimeKind.Local).AddTicks(8624), new DateTime(2022, 1, 4, 19, 1, 54, 366, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(4234), new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(6062), new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(6083), new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(9838), new DateTime(2022, 1, 4, 19, 1, 54, 367, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(1124), new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(7089), new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 1, 4, 19, 1, 54, 368, DateTimeKind.Local).AddTicks(7112) });
        }
    }
}
