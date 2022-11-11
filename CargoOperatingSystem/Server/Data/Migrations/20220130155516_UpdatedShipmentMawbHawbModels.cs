using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedShipmentMawbHawbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Commodity",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightNoAndDate",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Commodity",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightNoAndDate",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a653ffb3-b2d5-4dbe-8536-bf9b6e431ba7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a6da3f34-502b-48da-81db-c77401207a4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70fecd22-850a-4b27-a937-2cfa10c1d53c", "AQAAAAEAACcQAAAAELCtwQZUDOHTQ0i7p5OglgmdERgODRvJ/sKcy2XIb17ffoo7H63RLU9V4TMI2gmC3Q==", "78a303f6-215d-4fc9-b21c-f29be1c2afab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6936826-16b0-401e-a897-f984608c55c5", "AQAAAAEAACcQAAAAEFC0iJ46tkzJh+Jlb21QuYl/jkYXfOUIk+PNVGL3WTkk1Ly/J/7BZvAdcmEpFe/KGQ==", "b4d32ac3-4656-45d6-b3f9-38e35972ccf2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 206, DateTimeKind.Local).AddTicks(9742), new DateTime(2022, 1, 30, 16, 55, 15, 209, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(749), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2583), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2605), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3876) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commodity",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ThirdFlightNoAndDate",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "Commodity",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ThirdFlightNoAndDate",
                table: "Hawbs");

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
    }
}
