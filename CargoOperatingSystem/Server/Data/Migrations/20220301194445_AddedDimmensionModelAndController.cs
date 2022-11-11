using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedDimmensionModelAndController : Migration
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

            migrationBuilder.CreateTable(
                name: "Dimmension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimmension", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimmension_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c5951112-2bbf-47b4-bfbd-685b854e6ecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9651a44e-d830-4698-be14-1b49ef6faea3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c728fd48-6634-4c42-88e3-ba85e54f1df2", "AQAAAAEAACcQAAAAELQyZJB9XPmpg8nGS0N1kqCK/kpbVlnSCf24w2qDXfcW1q3ZSfSYaXX7EgmiGf8LqQ==", "1fe6d209-68a4-4264-94b2-0b55050eab21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a7e31f-945c-4349-b99c-94403577b409", "AQAAAAEAACcQAAAAEDezHwgBnDo7tH/lX2yBUEfxV3RLyOcuCprAlLmfClzL4QhUkJkTHquLUzrDw7H3eA==", "c4b0427f-5c4f-4bd3-a58e-267e7c48ff63" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 544, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 3, 1, 20, 44, 44, 547, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8808), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4174), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4193), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(8162), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(570), new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.CreateIndex(
                name: "IX_Dimmension_ShipmentId",
                table: "Dimmension",
                column: "ShipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dimmension");

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
