using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedShipmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Commodity",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstFlightDate",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightDest",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightNumber",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondFlightDate",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightDest",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightNumber",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThirdFlightDate",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightDest",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightNumber",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "eea6847a-ef7d-46bd-aee3-127c46251249");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c8bfc3db-e5ba-4872-8409-2092015b07d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1da1069a-882c-4256-b47e-f032de2c763a", "AQAAAAEAACcQAAAAEAu489TX4hl9JhqMofkD81W7EU/G2hvQeVjsvl3Vzk3pwY30UxMK9810hy9lUTlSBw==", "e98fe963-4012-4749-a035-7bc2bcd0fb4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d6721c-bd0f-4024-b3dc-2fcbbf769280", "AQAAAAEAACcQAAAAEHWvScIaClnFyX/r8HOZ8mBeNTnRPOq1G2mknb4Pl83QYlNU47ruK9MbwO2U1pRSjg==", "684e72ee-8f5a-46f0-a0c9-b1d0d63d1a15" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 594, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 1, 30, 13, 54, 14, 597, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(2002), new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(2094), new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(6058), new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(7864), new DateTime(2022, 1, 30, 13, 54, 14, 598, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(1415), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(2758), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(8685), new DateTime(2022, 1, 30, 13, 54, 14, 599, DateTimeKind.Local).AddTicks(8694) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commodity",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "FirstFlightDate",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "FirstFlightDest",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "FirstFlightNumber",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "SecondFlightDate",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "SecondFlightDest",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "SecondFlightNumber",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ThirdFlightDate",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ThirdFlightDest",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ThirdFlightNumber",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4a8a3126-f9d3-4153-ae29-79993b432805");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "54c0dd9e-7487-4c39-a708-df61620bed4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bcef6bf-1f88-408c-9217-7b839b671957", "AQAAAAEAACcQAAAAEAD9qt9IyWqlJ1fWfgqmC6iRNyIsG1oUSEKhf7HxIds5QaFeQeUD8Jz3EoPElqeUFQ==", "63663dc5-5596-45e6-abe8-6fa8d991c372" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39347697-c750-4062-a6dc-a85010d04850", "AQAAAAEAACcQAAAAEOjzIIEEjO1RG1c6Ot++Hfl+O06ENlQ3SMlNgWteIw/+xxTSAvWwnbV3rbsN7YXsCA==", "1de6d2db-a2e1-44a4-b447-d8652072ed09" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 104, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 1, 28, 17, 43, 27, 106, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7246), new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(1422), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(6698), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8216), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(1974), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3923), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3947) });
        }
    }
}
