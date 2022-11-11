using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbHawbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChargesAtDestCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChargesInDestCurrencyCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CurrencyConversionRates",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollectCharges",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChargesAtDestCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ChargesInDestCurrencyCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CurrencyConversionRates",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollectCharges",
                table: "Hawbs");

            migrationBuilder.AlterColumn<double>(
                name: "WeightChargePP",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "WeightChargeCC",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValuationChargePP",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValuationChargeCC",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrepaid",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCollect",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCharge",
                table: "Mawbs",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "TaxPP",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TaxCC",
                table: "Mawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RateCharge",
                table: "Mawbs",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "WeightChargePP",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "WeightChargeCC",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValuationChargePP",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ValuationChargeCC",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrepaid",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCollect",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCharge",
                table: "Hawbs",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "TaxPP",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TaxCC",
                table: "Hawbs",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RateCharge",
                table: "Hawbs",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c1e39714-00f2-4c9a-9aae-a21dd8b76fc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8a1b964e-837d-48b0-95a2-dad2b2017597");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46527a6d-1722-4747-a505-c832fcae2558", "AQAAAAEAACcQAAAAEMxq4YZAGmoj78OOSmZ8wh/lFHRHTD3eVKKVCTPa/ozlul/L7mv2GsZdnOdYzx17zQ==", "9824b872-0245-4016-8f8d-356f333fb596" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 964, DateTimeKind.Local).AddTicks(2530), new DateTime(2022, 1, 27, 13, 24, 21, 966, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8992), new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4901), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9733), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5618), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5621) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WeightChargePP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "WeightChargeCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ValuationChargePP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ValuationChargeCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalPrepaid",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalCollect",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalCharge",
                table: "Mawbs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TaxPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TaxCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "RateCharge",
                table: "Mawbs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "ChargesAtDestCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChargesInDestCurrencyCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyConversionRates",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollectCharges",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WeightChargePP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "WeightChargeCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ValuationChargePP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ValuationChargeCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalPrepaid",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TotalCollect",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalCharge",
                table: "Hawbs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TaxPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "TaxCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "RateCharge",
                table: "Hawbs",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "ChargesAtDestCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChargesInDestCurrencyCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyConversionRates",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollectCharges",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1af8f588-08fa-4221-ace8-03ba26a28ecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "78cbdbdc-3e2f-48ee-b415-67594e5202fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c4fdcb-f8fe-4232-9eba-b7e06160ff82", "AQAAAAEAACcQAAAAEJQ3CA69nrXvdeI+vD4bLw96QCU7pg17Kl12uPefRI5mJeuVM/j5TczBElBkhqsjZg==", "11d957b7-86ba-48c1-8515-2e9c388f273a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 312, DateTimeKind.Local).AddTicks(7278), new DateTime(2022, 1, 27, 10, 42, 36, 315, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(7928), new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(8036), new DateTime(2022, 1, 27, 10, 42, 36, 316, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(1988), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3759), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(7455), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8709), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 1, 27, 10, 42, 36, 317, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(2600), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4531), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4551), new DateTime(2022, 1, 27, 10, 42, 36, 318, DateTimeKind.Local).AddTicks(4554) });
        }
    }
}
