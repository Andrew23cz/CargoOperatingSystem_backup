using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class OfficeDbUpdate10JAN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "fb697d60-33b9-4333-99e0-52a5d82147c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e847a2e7-789a-4c4b-a006-a6d0ff51bc09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "671b0269-a18f-43a9-9a3c-5a631339df55", "AQAAAAEAACcQAAAAEEbJI0cVk8O1ABott5DVf9f0atVIyHGotGoztFIxkyIsOZ0VrRQW/ZIM/WGfvoO94w==", "9c9af84f-551e-4c59-819c-9deb519b62ca" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 826, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 1, 10, 9, 12, 33, 840, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 841, DateTimeKind.Local).AddTicks(4543), new DateTime(2022, 1, 10, 9, 12, 33, 841, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 841, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 1, 10, 9, 12, 33, 841, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(176), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(2393), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(7545), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(9163), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(9188), new DateTime(2022, 1, 10, 9, 12, 33, 842, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(6729), new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(6758), new DateTime(2022, 1, 10, 9, 12, 33, 843, DateTimeKind.Local).AddTicks(6762) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "e4e250b4-170e-447d-8739-b2d5e221f73b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f170b199-e931-4c8e-8a54-7c07eeb39bbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9442502d-04cf-490a-acca-979fc4e9f331", "AQAAAAEAACcQAAAAEOBWh7QdDjuhhUbGlYvKUi4gQjt0qMtgqOYrvRwHOOa6E3YCUXElHMVrbTQLTqbc4w==", "7c06fe18-10bf-490a-aa53-7d14a71b0378" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 577, DateTimeKind.Local).AddTicks(4755), new DateTime(2022, 1, 9, 14, 37, 58, 579, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9275), new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 1, 9, 14, 37, 58, 580, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(3363), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5101), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(8577), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 1, 9, 14, 37, 58, 581, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(3526), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5717), new DateTime(2022, 1, 9, 14, 37, 58, 582, DateTimeKind.Local).AddTicks(5720) });
        }
    }
}
