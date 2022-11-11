using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedShipmentModelByRemovingMawbIdAndWorkloadStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "WorkloadStatus",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a99a8714-cdb6-4ca5-a051-3a05079ace70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "22096599-10f4-4e3e-b518-093849d76b30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6541fe89-579e-4c8c-8978-a11e2fc6a2ad", "AQAAAAEAACcQAAAAEGTkD4FFkeJ9r3oL5juyf072v/maQgLY2d9evUy5PM7ptNO0QoTL5PJ2pt2j7Rmcww==", "633f9440-fd09-444f-a704-f5d7ecdfb98b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 56, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 1, 25, 20, 9, 11, 58, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9419), new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(3334), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5187), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(8702), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(139), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(3999), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6015), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6036), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6039) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadStatus",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4707ce73-4f68-411d-8b67-91064c1e703e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f3d6726f-1159-42d2-a713-f65dc0f4f1b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2f5b595-364d-4d54-a1fe-b4b98f177cec", "AQAAAAEAACcQAAAAEJ+0rg0Bn4z9rfasLSGdYC5wI0RfES0QMXD5pULv0aHmNqZRBKc7oGhXVojAbA/OAw==", "fba151d9-2be2-4de1-85a7-511a4d257367" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 487, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 1, 25, 19, 27, 32, 489, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7143), new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 1, 25, 19, 27, 32, 490, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(1198), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7956), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 1, 25, 19, 27, 32, 491, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4082), new DateTime(2022, 1, 25, 19, 27, 32, 492, DateTimeKind.Local).AddTicks(4084) });
        }
    }
}
