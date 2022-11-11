using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateDbAtOffice19Jan22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountingInfo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentAccountNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgentIataCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirlineHeader",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AmountOfInsurance",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "ChgsCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommodityItemNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyConversionRates",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfSignature",
                table: "Mawbs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeclaredValueCarriage",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeclaredValueCustoms",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstCarrierCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightDest",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstFlightNoAndDate",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInfo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssuingAgent",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NatureAndQttyGoods",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionalShippingInfoA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptionalShippingInfoB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeA",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeB",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherChargeD",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RateCharge",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RateClass",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceNo",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sci",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondCarrierCode",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightDest",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondFlightNoAndDate",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCharge",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollect",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCollectCharges",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueAgentCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueAgentPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalPrepaid",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuationChargeCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuationChargePP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightChargeCC",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightChargePP",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "placeOfSignature",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "81189344-f1b3-4226-8ee0-3e5f8f755f12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "eed75586-f26c-46c3-9da7-c81f1d8b54b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb972ff1-ba45-4ff0-a8a2-8ebd6fe2f2df", "AQAAAAEAACcQAAAAEB4PEMhGCxSlUOFxr3cNpb55iNJQW2aMOxyeZ4YS69FwuKvwzo1UsFuDzQqatfv69w==", "1926e362-b947-45ce-8aab-b47e86f14913" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 209, DateTimeKind.Local).AddTicks(7433), new DateTime(2022, 1, 19, 16, 34, 43, 222, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8551), new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8846), new DateTime(2022, 1, 19, 16, 34, 43, 223, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 224, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3479), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3525), new DateTime(2022, 1, 19, 16, 34, 43, 225, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6064), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 1, 19, 16, 34, 43, 226, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 227, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 1, 19, 16, 34, 43, 227, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(962), new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 1, 19, 16, 34, 43, 228, DateTimeKind.Local).AddTicks(995) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountingInfo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AgentAccountNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AgentIataCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AirlineHeader",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AmountOfInsurance",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChargesAtDestCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChargesInDestCurrencyCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ChgsCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CommodityItemNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CurrencyConversionRates",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "DateOfSignature",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "DeclaredValueCarriage",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "DeclaredValueCustoms",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "FirstCarrierCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "FirstFlightDest",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "FirstFlightNoAndDate",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "HandlingInfo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "IssuingAgent",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "NatureAndQttyGoods",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OptionalShippingInfoA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OptionalShippingInfoB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeA",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeB",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "OtherChargeD",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "RateCharge",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "RateClass",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ReferenceNo",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "Sci",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "SecondCarrierCode",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "SecondFlightDest",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "SecondFlightNoAndDate",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TaxCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TaxPP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalCharge",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollect",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalCollectCharges",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueAgentCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueAgentPP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueCarrierCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalOtherChargesDueCarrierPP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "TotalPrepaid",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ValuationChargeCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ValuationChargePP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "WeightChargeCC",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "WeightChargePP",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "placeOfSignature",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5485335c-8845-4f3d-b270-8a921dac8e88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "6a668037-0d9f-4758-bd7e-00916db6ab3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc06d603-ce82-4411-a52d-f3b05f16925d", "AQAAAAEAACcQAAAAEM+UqpC75eEnBDD8kh50wVns4DqIjDW4782Zxfs5cPnyd2XfZOP6iMryGXcIsvIaVQ==", "9c1dc61d-95e4-428f-b1bd-dea25b91c6bb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 596, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 1, 18, 11, 25, 7, 612, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7683), new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7859), new DateTime(2022, 1, 18, 11, 25, 7, 613, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(4633), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7369), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 1, 18, 11, 25, 7, 614, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(2754), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5275), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5306), new DateTime(2022, 1, 18, 11, 25, 7, 615, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9340), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 1, 18, 11, 25, 7, 617, DateTimeKind.Local).AddTicks(9434) });
        }
    }
}
