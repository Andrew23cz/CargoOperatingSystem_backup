using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ToUpdateOfficeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbCount",
                table: "AwbStock");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5485335c-8845-4f3d-b270-8a921dac8e88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "6a668037-0d9f-4758-bd7e-00916db6ab3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc06d603-ce82-4411-a52d-f3b05f16925d", "AQAAAAEAACcQAAAAEM+UqpC75eEnBDD8kh50wVns4DqIjDW4782Zxfs5cPnyd2XfZOP6iMryGXcIsvIaVQ==", "9c1dc61d-95e4-428f-b1bd-dea25b91c6bb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 596, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 1, 18, 11, 25, 7, 612, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7683), new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7859), new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(4633), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7369), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(2754), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5275), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5306), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9340), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9434) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwbCount",
                table: "AwbStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
