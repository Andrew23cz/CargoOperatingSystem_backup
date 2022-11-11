using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WtVal",
                table: "Mawbs",
                newName: "WtValPP");

            migrationBuilder.RenameColumn(
                name: "OtherChgsCode",
                table: "Mawbs",
                newName: "WtValCOL");

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAccountNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentCity",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCodeCOL",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCodePP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAccountNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "716f5702-56bc-408f-a533-ca518987c1e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "123556dc-9f67-441e-b300-e632e1724a2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0cbc80a-437b-4c82-815a-27f29b76275f", "AQAAAAEAACcQAAAAED+lt62ugtnwskf3uM8htIUHZx7Yd999rHxTPuPzrdxBmkn05qrFQD84VYrRl98wrw==", "cae33c1a-6756-4f67-9af4-f061edeb57ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8635a66d-d943-4cf6-8345-e2900be9d735", "AQAAAAEAACcQAAAAEBXK+wzv5v9NyQjF/z5iSKxeI/7JWmI1ZoAVAJHs3slT8iIt6h1NMS2hILx/K7Qa5Q==", "856bdc92-f12e-4bfc-a1c6-665061cfc559" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 163, DateTimeKind.Local).AddTicks(835), new DateTime(2022, 2, 16, 10, 51, 16, 165, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 2, 16, 10, 51, 16, 166, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 2, 16, 10, 51, 16, 167, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(4539), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6541), new DateTime(2022, 2, 16, 10, 51, 16, 168, DateTimeKind.Local).AddTicks(6544) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsigneeAccountNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentCity",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChgsCodeCOL",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChgsCodePP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAccountNo",
                table: "Mawbs");

            migrationBuilder.RenameColumn(
                name: "WtValPP",
                table: "Mawbs",
                newName: "WtVal");

            migrationBuilder.RenameColumn(
                name: "WtValCOL",
                table: "Mawbs",
                newName: "OtherChgsCode");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "40843e43-0837-40f7-860b-5396610958e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b63ff633-e377-4791-80df-03e97d965882");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3404062-5a5b-4f56-a7b2-9bbff8c5efad", "AQAAAAEAACcQAAAAEKzQQn9GmlTcwgqJbkQcna8bA1pyk/9CiimH7l57vJEBHfts4tGhsXcl4qhE7HyiRA==", "741309c9-7617-4681-b3fc-275f67fdd7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0f4341-ed9d-4e91-b294-1216d96f6aa5", "AQAAAAEAACcQAAAAEKdSye1rHmcPKBJnIr9vO6Hig+0LNcjGsPYgEdyu2IB1Dag0uKaY6HkFmGkQt/Blng==", "4bbe5542-3519-45c3-a9f7-1bb6a9b5b02e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 136, DateTimeKind.Local).AddTicks(3955), new DateTime(2022, 2, 1, 16, 15, 6, 139, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(5467), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7350), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7372), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(1054), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2417), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2438), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9754) });
        }
    }
}
