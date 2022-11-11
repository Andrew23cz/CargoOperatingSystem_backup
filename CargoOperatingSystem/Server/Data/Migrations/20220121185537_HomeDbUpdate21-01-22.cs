using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class HomeDbUpdate210122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "6507a919-e976-478f-a295-fd1e53ecdaf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ce254708-ca6b-49f6-8cd3-92529ec5a576");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b220a9-c728-4b51-94d8-c2570cdc6cfc", "AQAAAAEAACcQAAAAEB4Dd9Ka2VD0UUyXnfE+IQQ8A5P95up189AyYOlUnLbVUMawQWbPcmPoFXDp/kJWcA==", "40f51a12-a3ce-4508-9ecc-be3cbce75f00" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 567, DateTimeKind.Local).AddTicks(9756), new DateTime(2022, 1, 21, 19, 55, 36, 571, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1547), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7503), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7525), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(1432), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8773), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8798) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ae003d42-e469-46de-b6aa-11a06ab37cab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "912a7263-2108-4a36-8f88-5f7259bba18c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17990726-c61f-4ccb-a2cd-92cebe2435f7", "AQAAAAEAACcQAAAAEPKh+ZbTGIHm+EVIWNXBRR0A8l/xExhyXVpJ8mm7Nka6twyyn2pY6fG3x3qW6zVyVA==", "cbc43f6b-1d55-4494-8972-bf9e0ea26f43" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 446, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 1, 21, 15, 42, 59, 469, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9859), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9865) });
        }
    }
}
