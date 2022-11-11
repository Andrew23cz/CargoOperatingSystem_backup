using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class NewModelsImplementedCurrencyChargesAfRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SymbolCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AfRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryDesignator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IataNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CassNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAirportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationCountryIsoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GsaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dgr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrepaidRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginAirportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumRate = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    NormalFlatRate = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak45 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak100 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak250 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak300 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak500 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    RateWeightBreak1000 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    UldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PivotWeight = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    PivotRate = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    FlatPrice = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    OverPivotRate = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AfRates_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Charges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChargeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    ChargeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charges_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Charges_CurrencyId",
                table: "Charges",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfRates");

            migrationBuilder.DropTable(
                name: "Charges");

            migrationBuilder.DropTable(
                name: "Currency");

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
    }
}
