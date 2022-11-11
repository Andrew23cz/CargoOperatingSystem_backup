using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedWorkloadAmountToWorkload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "WorkloadAmount",
                table: "Workloads",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "44b5f85d-5870-467f-9168-6ceab03c7061");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "82ed74f5-c7d6-4202-a798-5c7ee9e87598");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d6fed5-5532-4e8e-b93e-b716eb5385b1", "AQAAAAEAACcQAAAAEFVM2zEMmr/LDJdH8eGWf/NHztLNR6h6feUCnAkWkkyTrk4T/q6i3pEhow2xOwP/Eg==", "ffea1814-16ad-435b-a135-c3e266256c34" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 275, DateTimeKind.Local).AddTicks(9966), new DateTime(2021, 12, 31, 15, 29, 17, 278, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 279, DateTimeKind.Local).AddTicks(7919), new DateTime(2021, 12, 31, 15, 29, 17, 279, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 279, DateTimeKind.Local).AddTicks(8021), new DateTime(2021, 12, 31, 15, 29, 17, 279, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(1835), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(3647), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(3667), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(7031), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(8258), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(8277), new DateTime(2021, 12, 31, 15, 29, 17, 280, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(2671), new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(4823), new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(4845), new DateTime(2021, 12, 31, 15, 29, 17, 281, DateTimeKind.Local).AddTicks(4847) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkloadAmount",
                table: "Workloads");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a167c300-8397-4f14-b2bb-91a2a1f8f27f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a3c0dfa5-8843-43bf-85f6-279841dbea27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1758914c-16ef-4bae-a143-6a61ada7551e", "AQAAAAEAACcQAAAAEJuluMTowoamu8DJfgL3ddFTqa2eKMHlFJzKNpnSXGgr8ETWtCuV0gU6ggO7aMDgPw==", "8e78953e-6ca9-4889-a499-5b772ed0cf0b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 23, DateTimeKind.Local).AddTicks(42), new DateTime(2021, 12, 29, 18, 38, 51, 25, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9660), new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9752), new DateTime(2021, 12, 29, 18, 38, 51, 26, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(3651), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5511), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5534), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(9115), new DateTime(2021, 12, 29, 18, 38, 51, 27, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(437), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(457), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(4386), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6518), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6540), new DateTime(2021, 12, 29, 18, 38, 51, 28, DateTimeKind.Local).AddTicks(6542) });
        }
    }
}
