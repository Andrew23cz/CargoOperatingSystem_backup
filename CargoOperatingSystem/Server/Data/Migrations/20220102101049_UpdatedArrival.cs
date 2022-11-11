using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedArrival : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4de7e38c-e4f0-48a8-b414-ca45c180fb8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0b102fbe-f089-4fc5-b586-6bfd70bea463");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22eba6f7-3efc-4f94-a6b3-a8a5008c9827", "AQAAAAEAACcQAAAAEJCpkmHjUIh2zoJwjfWO4LJJC5x8uhZpAjzytLKKg7f79zdU/ud0+vQb/QTOtF1JSg==", "86a80268-7fe2-4a4a-af74-2e80bdf18093" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 698, DateTimeKind.Local).AddTicks(9507), new DateTime(2022, 1, 2, 8, 50, 25, 701, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(217), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6036), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6056), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 1, 2, 8, 50, 25, 703, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1197), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(5225), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7159), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7178), new DateTime(2022, 1, 2, 8, 50, 25, 704, DateTimeKind.Local).AddTicks(7181) });

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
