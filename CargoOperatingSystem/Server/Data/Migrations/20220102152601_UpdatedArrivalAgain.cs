using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedArrivalAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "79f2d0c9-6caa-48fe-b53c-c2fb89a07c54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1811e1f7-6953-4c38-97bb-31787adf017b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e4ed07-fab4-415c-b120-d48bdcc5b217", "AQAAAAEAACcQAAAAEHuxZ3+KcbOv0PJ+tCKJyAC1vMFKp4MimROClGXCVKDkAw23sUyItHh+vy7yjLKR9A==", "5367e58a-7399-4969-bca6-db841389a73e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 580, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 1, 2, 14, 0, 39, 582, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7184), new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 1, 2, 14, 0, 39, 583, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(1115), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(6823), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8167), new DateTime(2022, 1, 2, 14, 0, 39, 584, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4354), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 2, 14, 0, 39, 585, DateTimeKind.Local).AddTicks(4377) });
        }
    }
}
