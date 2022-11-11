using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedAfRatesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AfRates_Currency_CurrencyId",
                table: "AfRates");

            migrationBuilder.DropIndex(
                name: "IX_AfRates_CurrencyId",
                table: "AfRates");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "AfRates");

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "AfRates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirlineName",
                table: "AfRates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode",
                table: "AfRates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "649fa06d-54e9-4fe4-810f-5220f8d39db2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "7bd948e2-9d7f-4ab7-8d5b-55b43475211a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84edd43-010e-4e92-ac53-09367cd46e15", "AQAAAAEAACcQAAAAEJQ1wkxz16wyPH5GtqGIWNwro5PkeOQ9p0y57ei++4PkhnU6cVTdvxrdRjhWmai/Vg==", "328efc0b-9ff2-475d-af57-74a208eee40b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55434ea0-b8a0-443b-b226-6007730d6c2a", "AQAAAAEAACcQAAAAEMJxYFtNKZ+mGOvm0Ec0y0TWfN41AIbIWIhlp9ElYJAq5EGS5fVrHwk+c/t1gVOHXA==", "b5537004-1ba7-4e09-9d81-b3719cb6e26a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 787, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 2, 28, 20, 31, 59, 790, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(3209), new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(7759), new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(9587), new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(9611), new DateTime(2022, 2, 28, 20, 31, 59, 791, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(3336), new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(4752), new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(9319), new DateTime(2022, 2, 28, 20, 31, 59, 792, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 793, DateTimeKind.Local).AddTicks(1387), new DateTime(2022, 2, 28, 20, 31, 59, 793, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 31, 59, 793, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 2, 28, 20, 31, 59, 793, DateTimeKind.Local).AddTicks(1415) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "AfRates");

            migrationBuilder.DropColumn(
                name: "AirlineName",
                table: "AfRates");

            migrationBuilder.DropColumn(
                name: "CurrencyCode",
                table: "AfRates");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "AfRates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "99dc6a5d-5edb-4bb8-a158-a9feed92d34b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "98a30643-6073-4746-a67f-6b47d716b14e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bacecc5-8440-4f26-be3c-dff2baedfff0", "AQAAAAEAACcQAAAAEBcE7g3FDmD8LqTH4uvgQNHjiGvln9WSF8cXU6fBFgUE1hts6nwnJKRdUfzqv6PX+w==", "9941d7a6-8b5d-4899-8b63-a9302e9d9908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bec4239-5c19-453e-96cc-6f1338058857", "AQAAAAEAACcQAAAAEB4P8+p3U1p8KvwukMn+TyJTIe2Pc2nag/+ZvdwStitM7keM6BNxoi3QbxtFMYVpDg==", "f2f938db-83c5-4443-9607-03dc347d6a24" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 973, DateTimeKind.Local).AddTicks(5367), new DateTime(2022, 2, 27, 19, 8, 0, 976, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(5287), new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(7331), new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(7353), new DateTime(2022, 2, 27, 19, 8, 0, 977, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(2377), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(2398), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(8605), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(8627), new DateTime(2022, 2, 27, 19, 8, 0, 978, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.CreateIndex(
                name: "IX_AfRates_CurrencyId",
                table: "AfRates",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AfRates_Currency_CurrencyId",
                table: "AfRates",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
