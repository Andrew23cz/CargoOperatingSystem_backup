using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdCarrierCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightDest",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ae003d42-e469-46de-b6aa-11a06ab37cab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "912a7263-2108-4a36-8f88-5f7259bba18c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17990726-c61f-4ccb-a2cd-92cebe2435f7", "AQAAAAEAACcQAAAAEPKh+ZbTGIHm+EVIWNXBRR0A8l/xExhyXVpJ8mm7Nka6twyyn2pY6fG3x3qW6zVyVA==", "cbc43f6b-1d55-4494-8972-bf9e0ea26f43" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 446, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 1, 21, 15, 42, 59, 469, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5252), new DateTime(2022, 1, 21, 15, 42, 59, 470, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 1, 21, 15, 42, 59, 471, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9859), new DateTime(2022, 1, 21, 15, 42, 59, 472, DateTimeKind.Local).AddTicks(9865) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtherChgsCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ThirdCarrierCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ThirdFlightDest",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4ea7e418-b1f2-477d-9aa9-14e62fe7b876");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "4ada1677-42dd-4f64-b730-e21804eb7155");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e44422-1bc0-49e1-9125-b23534d51461", "AQAAAAEAACcQAAAAEDO6par9Vz/Lo4I+GzOe//djbTIpKkph3yMD3dePzmf8DnkYzPAZglAsIyJDvSxmpw==", "18f03546-ca5c-486d-afdd-56f8c4efbacb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 294, DateTimeKind.Local).AddTicks(2277), new DateTime(2022, 1, 21, 15, 16, 32, 312, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(1351), new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(1531), new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(7378), new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(9827), new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(9853), new DateTime(2022, 1, 21, 15, 16, 32, 314, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(5794), new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 1, 21, 15, 16, 32, 315, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 317, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 1, 21, 15, 16, 32, 317, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 318, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 1, 21, 15, 16, 32, 318, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 15, 16, 32, 318, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 1, 21, 15, 16, 32, 318, DateTimeKind.Local).AddTicks(2061) });
        }
    }
}
