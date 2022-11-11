using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedAgentSubmitModelProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmitStatus",
                table: "AgentSubmitModel");

            migrationBuilder.AddColumn<double>(
                name: "ChargeableWeight",
                table: "AgentSubmitModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "AgentSubmitModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "d0aef859-bd75-4199-89c4-eee6120b21a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "fc9342a0-e1ea-4567-aaad-9f44df6e3f47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def8b214-3685-4370-abe2-f0e25b97ef02", "AQAAAAEAACcQAAAAECUX8Ge2IDkrhkuyrYYk+dxpM6XGqhoohVu5DPqvF0BIRrARJy8tEWS8q94cUE8d6Q==", "02324ecd-32b2-4556-a72a-0a4753abdb4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e46b529-51d8-49d8-bafc-2f4f9f4f5a08", "AQAAAAEAACcQAAAAED5Ev6zfdj73K4kIYsjUPszRYTNIcAui46VBTpxCKonh2C2MbKOKPWgaVNnlNIEkDA==", "3db74d53-20bd-4ca3-8371-dbfdb33b91f6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 818, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 3, 15, 14, 37, 9, 821, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(4201), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6271), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6293), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(588), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9290) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChargeableWeight",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "AgentSubmitModel");

            migrationBuilder.AddColumn<string>(
                name: "SubmitStatus",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b713d5bd-1726-4a35-88c5-4a6f917e09a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f1184c4e-f766-4010-9de1-a9a469100275");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c39dc1b-5ead-429b-8710-147965ec64af", "AQAAAAEAACcQAAAAEBYhMkJw8tHDCNfzp8LLWIAp6ubGAAtD3ysopHBJW6uvVAYk9GCGSBU25isFQ5tXWQ==", "6a553bc3-0def-4036-90b6-8a5a76cd75f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b38315d-286b-4f8c-9b19-0cac07fa7592", "AQAAAAEAACcQAAAAEBjpQffN9EfRO54H1LYKSV77OHb3AFtFkKguq3NaZCTQff6vsLL9FiS08ruyQiwgnw==", "caebcca4-dae8-4de5-bb52-10dd646e7085" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 448, DateTimeKind.Local).AddTicks(9995), new DateTime(2022, 3, 14, 14, 31, 48, 451, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 3, 14, 14, 31, 48, 452, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(1114), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(4631), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(5906), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(5926), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(9801), new DateTime(2022, 3, 14, 14, 31, 48, 453, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 454, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 3, 14, 14, 31, 48, 454, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 14, 14, 31, 48, 454, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 3, 14, 14, 31, 48, 454, DateTimeKind.Local).AddTicks(1817) });
        }
    }
}
