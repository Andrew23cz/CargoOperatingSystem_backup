using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class kurva04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "47dd157c-23b3-4383-a388-c96fcc25e002");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "226779e6-7d08-4cf2-b20e-5844e7649b74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b23c458a-66f9-4a28-8b4c-a950947eb525", "AQAAAAEAACcQAAAAEPdbnAKKNDSUZQY3ZeoA+ayGfhu1jzgJoy5a5P6CLwvtTMceRNp2oXEgF6qH0HSFWA==", "697202f4-0494-4a46-a79f-489e407892c5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 695, DateTimeKind.Local).AddTicks(2070), new DateTime(2022, 1, 24, 13, 0, 53, 697, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 698, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 1, 24, 13, 0, 53, 698, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 698, DateTimeKind.Local).AddTicks(8582), new DateTime(2022, 1, 24, 13, 0, 53, 698, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(2628), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(4475), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(4597), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(8352), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(9767), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 1, 24, 13, 0, 53, 699, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(5594), new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 1, 24, 13, 0, 53, 700, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_MawbId",
                table: "Shipments",
                column: "MawbId",
                unique: true,
                filter: "[MawbId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Mawbs_MawbId",
                table: "Shipments",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Mawbs_MawbId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_MawbId",
                table: "Shipments");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
