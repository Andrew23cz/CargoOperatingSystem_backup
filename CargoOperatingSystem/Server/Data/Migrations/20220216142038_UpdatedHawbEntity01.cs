using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedHawbEntity01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WtVal",
                table: "Hawbs",
                newName: "WtValPP");

            migrationBuilder.RenameColumn(
                name: "OtherChgsCode",
                table: "Hawbs",
                newName: "WtValCOL");

            migrationBuilder.AddColumn<string>(
                name: "CcChgsInDestCurrency",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChgsAtDest",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuCoRates",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgentCity",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCodeCOL",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCodePP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCcChgs",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4f6b0200-d1db-4e91-8aed-96090cd205d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ebf79039-22cd-4869-9047-5c28d29b7d54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acc7d994-3539-4e93-9571-3a79059dab30", "AQAAAAEAACcQAAAAEJZQxN6rlMFekE9Aig3Hf4acg4bLloVjaYo8l7syVIFp9WcHzFm2VPYHL2SuybOf9A==", "746a374c-94dc-40d0-89ba-4827d78bef14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d098e5-e652-4f65-8e2a-ead45b6869b1", "AQAAAAEAACcQAAAAEFSGkF2USYVs/Wg5muPnAXQZg04vUJ3LPoHLEchIZPIkpKkZ7UuEhqEQZBKzzAz9XA==", "b1fa0e82-79c4-4bce-a1e6-fb59d3e6c3e0" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 303, DateTimeKind.Local).AddTicks(2997), new DateTime(2022, 2, 16, 15, 20, 37, 306, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(271), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(5965), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(9635), new DateTime(2022, 2, 16, 15, 20, 37, 307, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(964), new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(6874), new DateTime(2022, 2, 16, 15, 20, 37, 308, DateTimeKind.Local).AddTicks(6876) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CcChgsInDestCurrency",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ChgsAtDest",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CuCoRates",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgentCity",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChgsCodeCOL",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChgsCodePP",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalCcChgs",
                table: "Hawbs");

            migrationBuilder.RenameColumn(
                name: "WtValPP",
                table: "Hawbs",
                newName: "WtVal");

            migrationBuilder.RenameColumn(
                name: "WtValCOL",
                table: "Hawbs",
                newName: "OtherChgsCode");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "2438c8ea-3100-494e-b54a-8a48c6d4b940");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c54a4a8-3065-43fe-b0c5-a698d4c9d778");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfebd7cb-2838-4863-a859-2483bd093ff2", "AQAAAAEAACcQAAAAEN9HZgrC6Wavsd9t2jCUZM4VuI7DjYDL5MOyON+243oSh12sWMggn+W4zfX23mBK9g==", "bb1278f1-6326-4df6-a581-26ba034a4f82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52fdce1b-04e1-45c1-99ca-2e74621f3b73", "AQAAAAEAACcQAAAAECgXcF5mx7qp5D8GD0k7u+/mV3f1of1MVeimvV9271UmcpPMybsPEBC5CMkrcAYhMA==", "248fd8d3-35eb-4ab6-9442-fafd12eeb171" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 213, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 2, 16, 12, 34, 43, 215, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(355), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(447), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 2, 16, 12, 34, 43, 217, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1072), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6915), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 2, 16, 12, 34, 43, 218, DateTimeKind.Local).AddTicks(6940) });
        }
    }
}
