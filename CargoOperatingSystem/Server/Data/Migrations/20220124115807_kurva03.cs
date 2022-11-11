using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class kurva03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b6ddb0fc-06f6-4088-84b4-04a04c680eea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "aa9e3e38-09ab-42a2-a9e8-2e98041f7fc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48f27cfc-fad8-4926-9640-40ce46dea780", "AQAAAAEAACcQAAAAEA9n9sQFVi5buAhqBfH0XiQG9CFRjPlv8R5xTTs2nNvi3ZKf3m/yfvidwZDIaS9Kdg==", "371617d0-e305-42cc-8183-74ebee7f4864" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 535, DateTimeKind.Local).AddTicks(6151), new DateTime(2022, 1, 24, 12, 58, 6, 538, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(3024), new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(3119), new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(8807), new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(8827), new DateTime(2022, 1, 24, 12, 58, 6, 539, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(3801), new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(3822), new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(7864), new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 1, 24, 12, 58, 6, 540, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 58, 6, 541, DateTimeKind.Local).AddTicks(22), new DateTime(2022, 1, 24, 12, 58, 6, 541, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "3014fc9a-d8f8-486e-baa6-44f4cda23be1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "84138e38-64f1-4437-898d-7bf8e14a6a08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "187f7a7f-57ef-4094-81a7-da787f317258", "AQAAAAEAACcQAAAAEKwVkp93q4jMgcUk5LfSfYsMR1iHPD/8ZHnJgoYaGA6nKkyms/a2arl+VVdhAh6TzA==", "843efa42-b005-4d57-932e-14854aa110e3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 951, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 1, 24, 12, 52, 5, 954, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7383), new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7478), new DateTime(2022, 1, 24, 12, 52, 5, 955, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(1325), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3158), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8040), new DateTime(2022, 1, 24, 12, 52, 5, 956, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4075), new DateTime(2022, 1, 24, 12, 52, 5, 957, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId");
        }
    }
}
