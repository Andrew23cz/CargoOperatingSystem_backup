using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ImplementedWorkloadRateSheetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkloadRateSheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwbIssuing = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    HawbIssuing = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    CargoLabels = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AcceptanceAssist = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    DocumentsCorrection = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    ImportCgoProcessing = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    PrintingCorrectedDocs = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    SpecCargoLabels = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AfterOpeningHoursService = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    ManualDataInsertion = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    PickUpDocuments = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    SecurityCheckPrepare = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    SecurityCheckAssist = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    PackingAssist = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AcceptanceAssistDG = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    CosultingDG = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AdditionalServiceA = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AdditionalServiceB = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AdditionalServiceC = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AdditionalServiceD = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    AdditionalServiceE = table.Column<decimal>(type: "decimal(12,4)", precision: 12, scale: 4, nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkloadRateSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkloadRateSheet_Currency_CurrencyId",
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
                value: "96aa3278-d17f-4254-a5a8-f253131d5ed5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "c3ead253-3b28-45f1-a83e-76b88cd10cc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1f467f-3b7e-4d7c-840d-94dca8e2341b", "AQAAAAEAACcQAAAAEKJZL9HC1oAPtELU7DB17THy6VDAuCUpzcF9w/4nygAfWnKR/EcoU8VHM6TdM8F+lg==", "d232c133-70c2-470f-a188-93b5ddedc4bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "154ed886-f2b4-4b92-8890-e0e55b8f899b", "AQAAAAEAACcQAAAAEC+3QgRC55BubTujBBGvmjy7puqSBifeP1D8rAwA7DQ/kZ30fSMpgQnefmJ/9b6O5A==", "efe45cd4-047b-4088-85c3-13fffcd37edc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 390, DateTimeKind.Local).AddTicks(6661), new DateTime(2022, 5, 4, 15, 10, 0, 393, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2567), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 4, 15, 10, 0, 394, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4042), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4063), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 5, 4, 15, 10, 0, 395, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 5, 4, 15, 10, 0, 396, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.CreateIndex(
                name: "IX_WorkloadRateSheet_CurrencyId",
                table: "WorkloadRateSheet",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkloadRateSheet");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "dd249c2d-b315-4b6c-9e97-80e4f0727ef9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8f6e919b-e66f-49ab-958e-9b9f2d7edf50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da127e5-ae2d-4f07-a47b-e21cea64b472", "AQAAAAEAACcQAAAAEBVm8HK3XL/sUnpIfygk28GkyufV7fIBWYrP6MNMqfNwxu8P4+ieFpBcqJee09HDgA==", "7695b089-30c9-48fa-a8c4-d02b96469392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc7d13b-2b21-455a-939d-386948c062bb", "AQAAAAEAACcQAAAAEF851oxtWLDugWxsPkeLmIuYe+9GPMUoKer8viPD4qfduaoR/8SYGqGqf1aHUlIzSA==", "cf23b2bd-1a44-47dd-a9d4-c140f567a9b7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 374, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 5, 2, 16, 22, 23, 376, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2184), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(5692), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(684), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2896), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2898) });
        }
    }
}
