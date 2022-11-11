using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedMawbAndHawbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Airline_AirlineId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Customers_CustomerId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AirlineId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_CustomerId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Hawbs");

            migrationBuilder.RenameColumn(
                name: "ShipperTemplate",
                table: "Hawbs",
                newName: "WtVal");

            migrationBuilder.RenameColumn(
                name: "ConsigneeTemplate",
                table: "Hawbs",
                newName: "WeightChargePP");

            migrationBuilder.AddColumn<string>(
                name: "AddressC",
                table: "Shippers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAddressC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountingInfoC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentAccountNumber",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentIataCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirlineAddressA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirlineAddressB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirlineName",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmountOfInsurance",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "ChgsCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommodityItemNo",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddressC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyConversionRates",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeclaredValueCarriage",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeclaredValueCustoms",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstCarrierCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightDest",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightNoAndDate",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInfoA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInfoB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInfoC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgent",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuingDate",
                table: "Hawbs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IssuingPersonFullName",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingPlace",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsD",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsE",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsF",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsG",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsH",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsI",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoodsJ",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionalShippingInfoA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionalShippingInfoB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeA",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeB",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeD",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChgsCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RateCharge",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RateClass",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceNo",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sci",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondCarrierCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightDest",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightNoAndDate",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAddressC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdCarrierCode",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdFlightDest",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCharge",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollect",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollectCharges",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalPrepaid",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuationChargeCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuationChargePP",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightChargeCC",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressC",
                table: "Consignees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8c335bac-dd94-415a-8fcc-80f1256f6059");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b95d74f2-ae4f-482a-85ee-dbaccc63fbf4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc24589-966a-458e-8231-27692c911e99", "AQAAAAEAACcQAAAAEJb6ipTFq4LnCqVlyr7UmxMDuTP6puZwvU53gzvcQjMsJp1HiYw41Q0NnoWSgHYMDw==", "706f9775-9552-4e7d-9f07-075813dd0f58" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 75, DateTimeKind.Local).AddTicks(5817), new DateTime(2022, 1, 26, 14, 43, 57, 78, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6635), new DateTime(2022, 1, 26, 14, 43, 57, 79, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(729), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2571), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2592), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(6151), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7429), new DateTime(2022, 1, 26, 14, 43, 57, 80, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3511), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3533), new DateTime(2022, 1, 26, 14, 43, 57, 81, DateTimeKind.Local).AddTicks(3536) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressC",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAddressC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AccountingInfoC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AgentAccountNumber",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AgentIataCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AirlineAddressA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AirlineAddressB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AirlineName",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AmountOfInsurance",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ChargesAtDestCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ChargesInDestCurrencyCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ChgsCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CommodityItemNo",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddressC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CurrencyConversionRates",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "DeclaredValueCarriage",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "DeclaredValueCustoms",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "FirstCarrierCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "FirstFlightDest",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "FirstFlightNoAndDate",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "HandlingInfoA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "HandlingInfoB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "HandlingInfoC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgent",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingDate",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingPersonFullName",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "IssuingPlace",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsD",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsE",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsF",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsG",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsH",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsI",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoodsJ",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OptionalShippingInfoA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OptionalShippingInfoB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeA",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeB",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeD",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "OtherChgsCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "RateCharge",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "RateClass",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ReferenceNo",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "Sci",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "SecondCarrierCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "SecondFlightDest",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "SecondFlightNoAndDate",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAddressC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TaxCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TaxPP",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ThirdCarrierCode",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ThirdFlightDest",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalCharge",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollect",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollectCharges",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueAgentCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueAgentPP",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "TotalPrepaid",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ValuationChargeCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ValuationChargePP",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "WeightChargeCC",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AddressC",
                table: "Consignees");

            migrationBuilder.RenameColumn(
                name: "WtVal",
                table: "Hawbs",
                newName: "ShipperTemplate");

            migrationBuilder.RenameColumn(
                name: "WeightChargePP",
                table: "Hawbs",
                newName: "ConsigneeTemplate");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Mawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Mawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Hawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConsigneeId",
                table: "Hawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Hawbs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a99a8714-cdb6-4ca5-a051-3a05079ace70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "22096599-10f4-4e3e-b518-093849d76b30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6541fe89-579e-4c8c-8978-a11e2fc6a2ad", "AQAAAAEAACcQAAAAEGTkD4FFkeJ9r3oL5juyf072v/maQgLY2d9evUy5PM7ptNO0QoTL5PJ2pt2j7Rmcww==", "633f9440-fd09-444f-a704-f5d7ecdfb98b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 56, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 1, 25, 20, 9, 11, 58, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9419), new DateTime(2022, 1, 25, 20, 9, 11, 59, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(3334), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5166), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5187), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(8702), new DateTime(2022, 1, 25, 20, 9, 11, 60, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(139), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(3999), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6015), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6036), new DateTime(2022, 1, 25, 20, 9, 11, 61, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AirlineId",
                table: "Hawbs",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_CustomerId",
                table: "Hawbs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Airline_AirlineId",
                table: "Hawbs",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Customers_CustomerId",
                table: "Hawbs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
