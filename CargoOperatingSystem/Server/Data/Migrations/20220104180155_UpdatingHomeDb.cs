using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingHomeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "735b03c3-7933-4dd2-a062-b6ffb65f1901");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c0213d07-8281-46bb-9f9a-2acb2f55b125");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad05184e-8719-46c0-b84a-51b08a6365d9", "AQAAAAEAACcQAAAAEEP2jnio1tTE1JCaA1IBjXbhfuMH0Rk2zodN2fO+hmn4f1Uk8n1cYWHAcRQDYi+/WA==", "0a121b13-6417-4627-81bc-c2f77e7dd53f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 683, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 1, 4, 15, 13, 27, 696, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1177), new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1399), new DateTime(2022, 1, 4, 15, 13, 27, 699, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(1170), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 1, 4, 15, 13, 27, 700, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(4558), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 1, 4, 15, 13, 27, 701, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 703, DateTimeKind.Local).AddTicks(5561), new DateTime(2022, 1, 4, 15, 13, 27, 703, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(553), new DateTime(2022, 1, 4, 15, 13, 27, 704, DateTimeKind.Local).AddTicks(565) });
        }
    }
}
