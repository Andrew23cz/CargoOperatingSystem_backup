using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedWorkload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AwbNumber",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateName",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "94551831-10cc-46ed-a7bb-f89da8ad5c9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "541a39f5-8d0a-4753-a5b2-bbd7cdcd1b02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3891b8e8-2e62-418d-ac9c-d11b76f27900", "AQAAAAEAACcQAAAAEJhEP0YFaqOLvosnnpRZzZYCQiXbImdTiMzA0kCQGpTHUUFQlTpJ9nY+edIa1xrKsw==", "7f8ba8ec-dfe8-46fc-8a0e-3cb8ada49ba6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 549, DateTimeKind.Local).AddTicks(8683), new DateTime(2021, 12, 29, 14, 11, 41, 552, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3802), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3897), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(7800), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9631), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9652), new DateTime(2021, 12, 29, 14, 11, 41, 553, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(3038), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4302), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4321), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(7966), new DateTime(2021, 12, 29, 14, 11, 41, 554, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(177), new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(199), new DateTime(2021, 12, 29, 14, 11, 41, 555, DateTimeKind.Local).AddTicks(201) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbNumber",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "TemplateName",
                table: "Workloads");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "746eb93e-0ef1-4df5-b1c4-2ad0ab91828a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b1163da0-7a27-4925-b3a5-857317b9bc92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897a31ae-a103-4c2b-a247-91f09644aa10", "AQAAAAEAACcQAAAAEHZMXFAI+X0vP96V38c35KE+Eda7y7yNTIz9J8Hc1N5vWFNZL9TXwgtO/MUpYh+C5Q==", "caf9804b-f4de-47be-8925-9e5f6045d8e0" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 673, DateTimeKind.Local).AddTicks(8207), new DateTime(2021, 12, 29, 13, 16, 57, 676, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3672), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(7492), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9397), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4173), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4192), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(7919), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9961), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9982), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9984) });
        }
    }
}
