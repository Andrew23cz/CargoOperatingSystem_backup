using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class MawbModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShipperTemplate",
                table: "Mawbs",
                newName: "WtVal");

            migrationBuilder.RenameColumn(
                name: "NatureAndQttyGoods",
                table: "Mawbs",
                newName: "NatureAndQttyGoodsJ");

            migrationBuilder.RenameColumn(
                name: "ConsigneeTemplate",
                table: "Mawbs",
                newName: "NatureAndQttyGoodsI");

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsD",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsE",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsF",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsG",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsH",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "6ccc3313-3548-408d-b1e1-61e97a8f345e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "89a176c3-9b4f-4370-a9c7-142623099a92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e51618e-7e68-4639-b91c-28f4fe00b46d", "AQAAAAEAACcQAAAAEIDYp0+HhvZMoBnOiVEQCFRHNff335uLf4ZEL5TwjrvXhZbnsvW/PLjoBfqtr4MNUQ==", "0e40c40b-c51e-4702-bcd2-5998e7b03a6b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 862, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 21, 12, 54, 0, 930, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 1, 21, 12, 54, 0, 933, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 934, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 1, 21, 12, 54, 0, 934, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 1, 21, 12, 54, 0, 935, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(5957), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9354), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9416), new DateTime(2022, 1, 21, 12, 54, 0, 939, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 940, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 1, 21, 12, 54, 0, 940, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4122), new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 21, 12, 54, 0, 941, DateTimeKind.Local).AddTicks(4191) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsD",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsE",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsF",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsG",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsH",
                table: "Mawbs");

            migrationBuilder.RenameColumn(
                name: "WtVal",
                table: "Mawbs",
                newName: "ShipperTemplate");

            migrationBuilder.RenameColumn(
                name: "NatureAndQttyGoodsJ",
                table: "Mawbs",
                newName: "NatureAndQttyGoods");

            migrationBuilder.RenameColumn(
                name: "NatureAndQttyGoodsI",
                table: "Mawbs",
                newName: "ConsigneeTemplate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8d30f52f-d1bc-4782-84da-ae853c2d74ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "58d88bfb-8914-4ae2-b9af-cd6358348db6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f400299-776f-4afb-b5a1-1180571c2a44", "AQAAAAEAACcQAAAAEEedUNqfqUAN+8zO6tPOvG+HgK/eG2edri9fojpBe++bq+e7M9TpEu3Qdrubbqi7gQ==", "609e0f78-1cde-44f9-96c2-f1c51f3f1dab" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 749, DateTimeKind.Local).AddTicks(9689), new DateTime(2022, 1, 21, 9, 3, 5, 761, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(9029), new DateTime(2022, 1, 21, 9, 3, 5, 762, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(5242), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7497), new DateTime(2022, 1, 21, 9, 3, 5, 763, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(2237), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3804), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3827), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 1, 21, 9, 3, 5, 764, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 1, 21, 9, 3, 5, 765, DateTimeKind.Local).AddTicks(1680) });
        }
    }
}
