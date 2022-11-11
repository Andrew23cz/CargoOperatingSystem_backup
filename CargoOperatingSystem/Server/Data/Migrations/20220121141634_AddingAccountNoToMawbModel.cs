using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddingAccountNoToMawbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgentAccountNumber",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentAccountNumber",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4e1cf942-6124-42f1-9e6c-87a4f484a5db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ee4db53c-b84c-4e04-a59e-71d8ab952328");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26ce2fd4-92f1-48e5-9a6b-322dc77c9e67", "AQAAAAEAACcQAAAAEAcGqneglT3eUJYno/OodkhNfw9DLq87Bvl6NdxHB4J6lYdtq9CMEMB6/RXfxBlCIA==", "69f083aa-5d4b-4fe6-b6fc-bc0d95842a47" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 307, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 1, 21, 14, 13, 48, 328, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9883), new DateTime(2022, 1, 21, 14, 13, 48, 332, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 333, DateTimeKind.Local).AddTicks(9861), new DateTime(2022, 1, 21, 14, 13, 48, 333, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 1, 21, 14, 13, 48, 334, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4846), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 1, 21, 14, 13, 48, 335, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 336, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 1, 21, 14, 13, 48, 336, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2461), new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2535), new DateTime(2022, 1, 21, 14, 13, 48, 337, DateTimeKind.Local).AddTicks(2541) });
        }
    }
}
