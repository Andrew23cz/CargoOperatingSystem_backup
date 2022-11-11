using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingOfficeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "df87b461-869f-45b3-9d57-bfe73ad5a7c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "271ab113-17cb-4169-b4fa-c28553276c23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da9929d6-b734-4e7c-ae62-48ac414be61d", "AQAAAAEAACcQAAAAEK+us6QyzniL09pqPI5q8UIgF6jEbgkTDpmIvqfSVWvp8+prufnOpYnHYM750Pnbsg==", "2ba07d92-824c-48be-b087-e3c9a0529dfc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 577, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 1, 3, 9, 15, 28, 589, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8305), new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8442), new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(8341), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9983), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(5585), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8015), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8041), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8044) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "bf647e22-c96b-4db2-96ae-f6943bac330b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0e298a68-fc5c-49d5-ad9e-9047c6988840");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa929589-b485-49a9-bf37-be5d1138d554", "AQAAAAEAACcQAAAAEFGu4y5nlF43G3V5Vq+pzGLVXzys94xk4JLGughwW/1fIwAyZMHd6wvC8eAbqZqf2Q==", "6ae8ad89-0a3c-4558-99c1-e17395a0f34d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 697, DateTimeKind.Local).AddTicks(5902), new DateTime(2022, 1, 2, 16, 26, 0, 700, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(1401), new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(1491), new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(7158), new DateTime(2022, 1, 2, 16, 26, 0, 701, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(636), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(1928), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(7704), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 1, 2, 16, 26, 0, 702, DateTimeKind.Local).AddTicks(7728) });
        }
    }
}
