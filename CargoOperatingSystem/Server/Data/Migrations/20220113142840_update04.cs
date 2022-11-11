using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class update04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "872eaab8-c4e9-47d2-ad56-20c1b05b7d75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "13a43c1b-dad1-4d5f-9b30-9904f664299b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfd8787c-c249-4fde-a0cc-dde761fd8599", "AQAAAAEAACcQAAAAEKpef6sXT2f51eOnTB/SCKaIIMKX67A3rPfiVrA80WcRI+sSG8ZmQwR5t4MfnmS+rA==", "4abcb543-19c1-4e53-8483-c30d3e608859" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 81, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 1, 13, 15, 28, 39, 94, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(5766), new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5512), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(2296), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6042), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7717), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "794df704-60dc-43da-aac9-88da2b49800c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e629e49e-bb02-4bbe-a49e-170082234989");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c49e8c9-82ef-469c-94ef-ee3f94063f1c", "AQAAAAEAACcQAAAAEPYyEkNKxuJq1P3Uo9rv9oR74LjO6+UtfXAsQZK6OP2WMSfIl6KqXqUs1OU7AZ4dNQ==", "fae0de51-ed7a-4618-bd93-0fab254c1de0" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 759, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 1, 13, 14, 47, 38, 771, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5808), new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5944), new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(1350), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3684), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(8838), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7788), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id");
        }
    }
}
