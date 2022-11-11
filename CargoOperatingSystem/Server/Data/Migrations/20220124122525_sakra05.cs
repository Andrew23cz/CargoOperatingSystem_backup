using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class sakra05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "d85ebda2-bc1d-46d1-96e0-74a3f5fbea9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "4abeb40f-6d90-43a3-bd1b-ad3e0d1e7a5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6646fd36-8e18-4b58-b745-7c86bd875c0a", "AQAAAAEAACcQAAAAEEpI11+ykpgKuzPphe1GMR1nzRk5QIe2ssufrVhyPAC3+VyXN+TH31VWt2AYPRLG6w==", "3f66ea54-19d9-4b9c-939a-198b9e66eaf9" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 796, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 1, 24, 13, 25, 24, 799, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(801), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(892), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(4823), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 1, 24, 13, 25, 24, 800, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1709), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(5497), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7618), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 1, 24, 13, 25, 24, 801, DateTimeKind.Local).AddTicks(7641) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
