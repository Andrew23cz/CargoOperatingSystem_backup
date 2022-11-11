using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedArrival01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Arrival_ArrivalId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_ArrivalId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "Suppliers");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Arrival",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "cf12ef9e-5328-4049-8943-36b789887fdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ea601956-fefa-4ff9-abcd-504e5a600430");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd527d62-04e0-457b-a9d8-5812c167b2fe", "AQAAAAEAACcQAAAAEMRvagk+jiKo99B7Ssw19u+p2jRAi70jAyGUNOYlAIKiloMNjHopHm1BisKxv7sdjg==", "bce93853-77b7-483a-9e61-a2d758824040" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 797, DateTimeKind.Local).AddTicks(4771), new DateTime(2022, 1, 2, 11, 56, 20, 800, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(8264), new DateTime(2022, 1, 2, 11, 56, 20, 801, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(205), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5216), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(9195), new DateTime(2022, 1, 2, 11, 56, 20, 802, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 1, 2, 11, 56, 20, 803, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.CreateIndex(
                name: "IX_Arrival_SupplierId",
                table: "Arrival",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arrival_Suppliers_SupplierId",
                table: "Arrival");

            migrationBuilder.DropIndex(
                name: "IX_Arrival_SupplierId",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Arrival");

            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "91fb477e-81fc-4ce7-a9fa-3680fddd4a22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b137eaf8-3398-4287-bb6f-12b11fd39271");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9678c412-dfc1-4431-a8d2-7d22b053f981", "AQAAAAEAACcQAAAAEMORud4kTah33G7lH9D8FuRPMZwQPPi/UFtd1RKE8EwoMsbm35rbAxiGCMXkMzDZAQ==", "eecc43c8-c86c-4705-8a03-713dc200791f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 670, DateTimeKind.Local).AddTicks(9755), new DateTime(2022, 1, 2, 11, 10, 48, 673, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(4901), new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 1, 2, 11, 10, 48, 674, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(818), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(4462), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(5763), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(9583), new DateTime(2022, 1, 2, 11, 10, 48, 675, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 676, DateTimeKind.Local).AddTicks(1602), new DateTime(2022, 1, 2, 11, 10, 48, 676, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 11, 10, 48, 676, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 1, 2, 11, 10, 48, 676, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ArrivalId",
                table: "Suppliers",
                column: "ArrivalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Arrival_ArrivalId",
                table: "Suppliers",
                column: "ArrivalId",
                principalTable: "Arrival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
