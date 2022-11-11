using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbHawbCustomerModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoicingAddress",
                table: "Customers",
                newName: "InvoicingAddressC");

            migrationBuilder.RenameColumn(
                name: "HqAddress",
                table: "Customers",
                newName: "InvoicingAddressB");

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentAddressC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HqAddressA",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HqAddressB",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HqAddressC",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoicingAddressA",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1af8f588-08fa-4221-ace8-03ba26a28ecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "78cbdbdc-3e2f-48ee-b415-67594e5202fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c4fdcb-f8fe-4232-9eba-b7e06160ff82", "AQAAAAEAACcQAAAAEJQ3CA69nrXvdeI+vD4bLw96QCU7pg17Kl12uPefRI5mJeuVM/j5TczBElBkhqsjZg==", "11d957b7-86ba-48c1-8515-2e9c388f273a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 312, DateTimeKind.Local).AddTicks(7278), new DateTime(2022, 1, 27, 10, 42, 36, 315, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(7928), new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(8036), new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddressA", "InvoicingAddressA", "InvoicingAddressB", "InvoicingAddressC" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(1988), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(2004), "K letisti 15, Praha 6", "K letisti 15, Praha 6", null, null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddressA", "InvoicingAddressA", "InvoicingAddressB", "InvoicingAddressC" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3751), "U Zlicina 25, Praha 6", "U Zlicina 25, Praha 6", null, null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddressA", "InvoicingAddressA", "InvoicingAddressB", "InvoicingAddressC" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3759), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3761), "Laglerove 4, Praha 6", "Laglerove 4, Praha 6", null, null });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8709), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(2600), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4531), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4551), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4554) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentAddressC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "HqAddressA",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HqAddressB",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HqAddressC",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoicingAddressA",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "InvoicingAddressC",
                table: "Customers",
                newName: "InvoicingAddress");

            migrationBuilder.RenameColumn(
                name: "InvoicingAddressB",
                table: "Customers",
                newName: "HqAddress");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9d1454bb-cca2-452f-bd2c-a531df5c566e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "21774e0f-e031-458f-82a8-8d9e1ba31795");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d793b65-467c-419b-9938-e8efb620eea9", "AQAAAAEAACcQAAAAEEvkdQGzf3CKu1/impXohoepRdVxY3jekgn0v0lN1yDu1hr/WW/R6yuU1af5+OhsDw==", "fa2fb41f-b6b8-495a-a7ad-9a97cec2d0d5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 422, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 1, 26, 16, 5, 13, 425, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddress", "InvoicingAddress" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 1, 26, 16, 5, 13, 426, DateTimeKind.Local).AddTicks(9762), "K letisti 15, Praha 6", "K letisti 15, Praha 6" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddress", "InvoicingAddress" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1569), "U Zlicina 25, Praha 6", "U Zlicina 25, Praha 6" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "HqAddress", "InvoicingAddress" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1579), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(1581), "Laglerove 4, Praha 6", "Laglerove 4, Praha 6" });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6536), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 1, 26, 16, 5, 13, 427, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2686), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2707), new DateTime(2022, 1, 26, 16, 5, 13, 428, DateTimeKind.Local).AddTicks(2710) });
        }
    }
}
