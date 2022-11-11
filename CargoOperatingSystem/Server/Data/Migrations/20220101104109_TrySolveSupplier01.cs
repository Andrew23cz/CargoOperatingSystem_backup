using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class TrySolveSupplier01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "e986da29-a594-418e-a279-6d9b9c5b8cde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9671a95a-fa4b-477c-845f-3e78d0467853");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83a3b075-0a10-4f17-af51-0fd437226860", "AQAAAAEAACcQAAAAEHXzYOFJJ3sC298Tk4TQBdyaAgoMGESByH8bHkogxkuTBh32PIrTu6W8+KluxoF8kA==", "3fe98395-d4fb-47b5-bbc0-697d07cf068e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 993, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 1, 1, 11, 41, 8, 996, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1004), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1094), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(4858), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6675), new DateTime(2022, 1, 1, 11, 41, 8, 997, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1583), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1604), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7592), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 1, 1, 11, 41, 8, 998, DateTimeKind.Local).AddTicks(7617) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
