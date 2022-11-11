using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class RemovedWorkloadRateSheetToShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_WorkloadRateSheet_WorkloadRateSheetId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_WorkloadRateSheetId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "WorkloadRateSheetId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4c449472-0a39-4367-bec5-24b051906eb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "cad5991d-1776-4c2c-a886-fcf6d962742c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1917f8fb-d5a9-40ac-afaf-52a7df9a7682", "AQAAAAEAACcQAAAAEL3Z0PD1l4P233S8UGItTfh4bebukLbp44qGJUj61Tb+kTT6Th1UiLrrpqpGeY4+LA==", "89368419-4b3f-4447-83f1-88391d83d312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18038a32-a990-4fc4-a9d0-70504ee6289c", "AQAAAAEAACcQAAAAEGIPYKxFj8fn+90ygQst+m8GiD7ri+X8lEOo0MYpMWq5A+onCMpJ1jfPmDLlBy/+dA==", "d77273ff-74e3-4d72-9104-e937d992edd5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 103, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 7, 1, 15, 41, 36, 105, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(5809), new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 7, 1, 15, 41, 36, 106, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(1581), new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(5273), new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(6628), new DateTime(2022, 7, 1, 15, 41, 36, 107, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(604), new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(2672), new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 7, 1, 15, 41, 36, 108, DateTimeKind.Local).AddTicks(2698) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkloadRateSheetId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "eaddc23a-7843-4633-b6be-06ef543836bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "4f888dad-aee6-42bb-9ddb-9bef62acd868");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "164e7d75-bc05-45ea-955a-57954c660040", "AQAAAAEAACcQAAAAEIpPL49xHoQ6EYmb6LY6Rd6xyM+1ZSAI93F1vhIcJxB0WfViuNB6P9s3xpH4rMbwLA==", "b50e5f57-fab1-4207-ae05-48b22e55a270" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40475b71-626f-4640-8963-b8a518ee3540", "AQAAAAEAACcQAAAAEP582lTzZmSMOnfZ3UajuEdhmCXobOqPhSMunibD1DGB2vvlcYDB4g60uXUC9OToLw==", "7d997511-023c-413b-9ee6-68ce6d10d3e6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 196, DateTimeKind.Local).AddTicks(9385), new DateTime(2022, 7, 1, 15, 16, 0, 199, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(4895), new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 7, 1, 15, 16, 0, 200, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(755), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(5705), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(5726), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(9797), new DateTime(2022, 7, 1, 15, 16, 0, 201, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 202, DateTimeKind.Local).AddTicks(1813), new DateTime(2022, 7, 1, 15, 16, 0, 202, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 1, 15, 16, 0, 202, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 7, 1, 15, 16, 0, 202, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_WorkloadRateSheetId",
                table: "Shipments",
                column: "WorkloadRateSheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_WorkloadRateSheet_WorkloadRateSheetId",
                table: "Shipments",
                column: "WorkloadRateSheetId",
                principalTable: "WorkloadRateSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
