using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedWorkloadRateSheetToShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "9ddd5094-de71-43e0-8784-f6fe44abd63e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "545e4fb1-a943-40c2-af1c-637211f57f31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b99ffe0-6420-483a-a973-40e0ead55f88", "AQAAAAEAACcQAAAAEFzJe/eHfNmgip1soJ/rjqwal0UNEvmStNQ1x1uHSiarZaoAkpObBrTZil2zuNoRaA==", "e0b54343-12e2-490a-9012-816165bdc85b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ac3adeb-446a-45f3-954d-4752edce3a64", "AQAAAAEAACcQAAAAEKrD88X6LIrsqB8EJugSa+UZQnV+HXhy2F1ZYeOPjmVR7dc5uKcdowP3Ty+xRU+vUw==", "3cd0de83-1343-4c93-bc91-f68c7098ead6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 959, DateTimeKind.Local).AddTicks(37), new DateTime(2022, 5, 25, 11, 36, 46, 961, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4792), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1549), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6798), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(919), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3184) });
        }
    }
}
