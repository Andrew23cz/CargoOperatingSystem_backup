using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class NewModelChargeTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChargeTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChargeDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    ChargeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyingSelling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginAirport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    AirlineId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargeTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChargeTemplate_Airline_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChargeTemplate_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChargeTemplate_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b1522e29-0bb6-4b35-89cd-d124698d8094");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "105939ed-9abb-40f8-b755-8fe0d2ead0df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e52e50-cd08-4526-85fa-cc6071d0333b", "AQAAAAEAACcQAAAAEO8eBb6ztyCMfKIRLu6UPKyBRvMsmUHyMMReHllC9LU23NaPjL9mKGf+8IJO0DvRbw==", "f2b9e2aa-341d-4583-9f20-adea81949e95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38f65b5e-266b-4ad3-9dac-3b0d8fa40a43", "AQAAAAEAACcQAAAAEEnkrdFfiL9AQ6nyzDXY8CkYDn+eOR4vQ5t5viMfs4+GOn3Ma6AXpU1esvnlSJiXeg==", "eaca0b6e-c1e4-4696-b995-0fb35d2a4f10" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 849, DateTimeKind.Local).AddTicks(8207), new DateTime(2022, 5, 2, 15, 32, 8, 852, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2705), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8556), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8579), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3606), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(7509), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9669), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.CreateIndex(
                name: "IX_ChargeTemplate_AirlineId",
                table: "ChargeTemplate",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_ChargeTemplate_CurrencyId",
                table: "ChargeTemplate",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChargeTemplate_SupplierId",
                table: "ChargeTemplate",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChargeTemplate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c8ec71ea-9e60-4ce8-a13c-8d72468d36af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ee3720c9-9d3f-46ce-8d87-f552a7ad040e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfec5ae-f276-45c5-b019-904f6fb1a960", "AQAAAAEAACcQAAAAEOzzG3hklfdyLj6uqq6Sd6WFsuVgJXFMiBzMuoSIlIzYVtYGxY2KkCDVbzHYYuKkwQ==", "ac98684b-0205-4ca3-85f2-f3aebec867d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92b6218e-4a39-42e9-85aa-6decab1e7e99", "AQAAAAEAACcQAAAAEPWQ7FBwt5UmX9+Uzm4vR3V992p7ffDbWUP37Lns/oF+5/bgX2T66nZ8nihQzmnoyQ==", "396c2bc4-aa12-41bd-8534-31d06baa439f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 536, DateTimeKind.Local).AddTicks(7849), new DateTime(2022, 4, 29, 19, 56, 2, 539, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(8017), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9898), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(3497), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4861), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(856), new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(878), new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(880) });
        }
    }
}
