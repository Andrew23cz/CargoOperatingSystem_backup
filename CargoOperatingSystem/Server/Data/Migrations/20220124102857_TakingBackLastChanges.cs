using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class TakingBackLastChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a53cbe73-1a8f-4b92-a734-74cd56ef22e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c3ad064-be50-443b-b073-6a52fb2cf944");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9df07972-7545-46d9-b80f-9ec58170bc8e", "AQAAAAEAACcQAAAAENXdn0sYYLwSkiVqlYKOFlRm1JpttyXbd2jBo4h9mYIBIfvfcWnzhwrnOM4gj/C4/A==", "587e1659-0800-4958-8a66-93059737b9ff" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 118, DateTimeKind.Local).AddTicks(5767), new DateTime(2022, 1, 24, 11, 28, 57, 121, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2703), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(7863), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9808), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 24, 11, 28, 57, 122, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 1, 24, 11, 28, 57, 123, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1264), new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1286), new DateTime(2022, 1, 24, 11, 28, 57, 124, DateTimeKind.Local).AddTicks(1288) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5bee3432-e144-49ef-9348-2455e966e65c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "6ce8b6f7-9af4-4560-869b-b1795b8f6e2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8828f3e-93f9-401d-aa71-45da1c5b0469", "AQAAAAEAACcQAAAAEJnvtUVnF3R36lyEXybOmi2zeEQyPe2S1rojh837xnE21s6m2+lG0FNVnDjQD2pxtQ==", "e94c55f3-bd9d-4786-bb8a-4e05bd1a4f9d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 326, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 22, 15, 19, 15, 329, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3891), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7821), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9625), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9703), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(405), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(430) });
        }
    }
}
