using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SupplierPhoneNumberSetToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ac7e28aa-e027-4f4d-b44f-337c5842a7dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1ea02004-a8d2-4bfa-b51b-eaf3aad0abad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "839cadea-0445-4787-95a3-4a5c2d77113d", "AQAAAAEAACcQAAAAEKumpAhkAuz+tltczl6C4KjgFax+JSuc66m1ZxyYIW/C50Rn0k82+oV2JnAG8b9Gdg==", "d95c5ba1-5493-4059-b787-b70cf8d61fdf" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 789, DateTimeKind.Local).AddTicks(2290), new DateTime(2022, 1, 1, 11, 12, 1, 791, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 792, DateTimeKind.Local).AddTicks(8134), new DateTime(2022, 1, 1, 11, 12, 1, 792, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 792, DateTimeKind.Local).AddTicks(8226), new DateTime(2022, 1, 1, 11, 12, 1, 792, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(2132), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(3905), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(3925), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(7419), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(8699), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(8718), new DateTime(2022, 1, 1, 11, 12, 1, 793, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(5084), new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(5106), new DateTime(2022, 1, 1, 11, 12, 1, 794, DateTimeKind.Local).AddTicks(5109) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
