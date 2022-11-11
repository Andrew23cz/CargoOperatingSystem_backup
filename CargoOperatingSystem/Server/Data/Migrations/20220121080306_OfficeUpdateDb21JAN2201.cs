using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class OfficeUpdateDb21JAN2201 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8d30f52f-d1bc-4782-84da-ae853c2d74ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "58d88bfb-8914-4ae2-b9af-cd6358348db6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f400299-776f-4afb-b5a1-1180571c2a44", "AQAAAAEAACcQAAAAEEedUNqfqUAN+8zO6tPOvG+HgK/eG2edri9fojpBe++bq+e7M9TpEu3Qdrubbqi7gQ==", "609e0f78-1cde-44f9-96c2-f1c51f3f1dab" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 749, DateTimeKind.Local).AddTicks(9689), new DateTime(2022, 1, 21, 9, 3, 5, 761, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(9029), new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(5242), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7497), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(2237), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3804), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3827), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1680) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b8b9b454-e0cd-4275-8947-b3dce7128243");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ef3eaec7-3e84-49d1-9bb0-1ea5c0f33156");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81018f8a-903d-43fc-b409-cc336c126127", "AQAAAAEAACcQAAAAEHoiS9XCEJ2hgTJaIfWHsHmDOwlkxUs++gq0uPvyk5GVK+hrcqLWY4ri6kWcHJbCAg==", "1c60115c-a2b6-4138-9260-95976d58e7ee" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 335, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 20, 21, 47, 55, 337, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 1, 20, 21, 47, 55, 338, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(2824), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4543), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4563), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(8114), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9451), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 1, 20, 21, 47, 55, 339, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5489), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5512), new DateTime(2022, 1, 20, 21, 47, 55, 340, DateTimeKind.Local).AddTicks(5515) });
        }
    }
}
