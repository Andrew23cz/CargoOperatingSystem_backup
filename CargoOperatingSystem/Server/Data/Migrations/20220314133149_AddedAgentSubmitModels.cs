using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedAgentSubmitModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentSubmitConsignee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitConsignee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentSubmitModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwbNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    FirstFlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThirdFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmitStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalDriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalDriverPhone = table.Column<int>(type: "int", nullable: true),
                    ArrivalCarColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalLicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickupAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickupDeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkloadAmount = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    WorkloadAwbIssuing = table.Column<int>(type: "int", nullable: false),
                    WorkloadHawbIssuing = table.Column<int>(type: "int", nullable: false),
                    WorkloadCargoLabels = table.Column<int>(type: "int", nullable: false),
                    WorkloadAcceptanceAssist = table.Column<int>(type: "int", nullable: false),
                    WorkloadDocumentsCorrection = table.Column<int>(type: "int", nullable: false),
                    WorkloadImportCgoProcessing = table.Column<int>(type: "int", nullable: false),
                    WorkloadPrintingCorrectedDocs = table.Column<int>(type: "int", nullable: false),
                    WorkloadSpecCargoLabels = table.Column<int>(type: "int", nullable: false),
                    WorkloadAfterOpeningHoursService = table.Column<int>(type: "int", nullable: false),
                    WorkloadManualDataInsertion = table.Column<int>(type: "int", nullable: false),
                    WorkloadPickUpDocuments = table.Column<int>(type: "int", nullable: false),
                    WorkloadSecurityCheckPrepare = table.Column<int>(type: "int", nullable: false),
                    WorkloadSecurityCheckAssist = table.Column<int>(type: "int", nullable: false),
                    WorkloadPackingAssist = table.Column<int>(type: "int", nullable: false),
                    WorkloadAcceptanceAssistDG = table.Column<int>(type: "int", nullable: false),
                    WorkloadConsultingDG = table.Column<int>(type: "int", nullable: false),
                    Submitted = table.Column<bool>(type: "bit", nullable: false),
                    Processed = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentSubmitModel_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgentSubmitShipper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitShipper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgentSubmitDim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    AgentSubmitModelId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitDim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentSubmitDim_AgentSubmitModel_AgentSubmitModelId",
                        column: x => x.AgentSubmitModelId,
                        principalTable: "AgentSubmitModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgentSubmitHawb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HawbNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AwbNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentIataCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionalShippingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionalShippingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChgsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WtValPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WtValCOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChgsCodePP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChgsCodeCOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredValueCarriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredValueCustoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfInsurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityItemNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateCharge = table.Column<double>(type: "float", nullable: false),
                    TotalCharge = table.Column<double>(type: "float", nullable: false),
                    NatureAndQttyGoodsA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightChargePP = table.Column<double>(type: "float", nullable: false),
                    WeightChargeCC = table.Column<double>(type: "float", nullable: false),
                    ValuationChargePP = table.Column<double>(type: "float", nullable: false),
                    ValuationChargeCC = table.Column<double>(type: "float", nullable: false),
                    TaxPP = table.Column<double>(type: "float", nullable: false),
                    TaxCC = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueAgentPP = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueAgentCC = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueCarrierPP = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueCarrierCC = table.Column<double>(type: "float", nullable: false),
                    TotalPrepaid = table.Column<double>(type: "float", nullable: false),
                    TotalCollect = table.Column<double>(type: "float", nullable: false),
                    CuCoRates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcChgsInDestCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChgsAtDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCcChgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuingPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingPersonFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    ChargeableWeight = table.Column<double>(type: "float", nullable: false),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ConsigneeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneePhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Submitted = table.Column<bool>(type: "bit", nullable: false),
                    Processed = table.Column<bool>(type: "bit", nullable: false),
                    AgentSubmitShipperId = table.Column<int>(type: "int", nullable: true),
                    AgentSubmitConsigneeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitHawb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentSubmitHawb_AgentSubmitConsignee_AgentSubmitConsigneeId",
                        column: x => x.AgentSubmitConsigneeId,
                        principalTable: "AgentSubmitConsignee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AgentSubmitHawb_AgentSubmitShipper_AgentSubmitShipperId",
                        column: x => x.AgentSubmitShipperId,
                        principalTable: "AgentSubmitShipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AgentSubmitMawb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwbNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAgentAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentIataCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdFlightNoAndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandlingInfoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountingInfoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionalShippingInfoA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionalShippingInfoB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChgsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WtValPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WtValCOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChgsCodePP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChgsCodeCOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredValueCarriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclaredValueCustoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfInsurance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityItemNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateCharge = table.Column<double>(type: "float", nullable: false),
                    TotalCharge = table.Column<double>(type: "float", nullable: false),
                    NatureAndQttyGoodsA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureAndQttyGoodsJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherChargeD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightChargePP = table.Column<double>(type: "float", nullable: false),
                    WeightChargeCC = table.Column<double>(type: "float", nullable: false),
                    ValuationChargePP = table.Column<double>(type: "float", nullable: false),
                    ValuationChargeCC = table.Column<double>(type: "float", nullable: false),
                    TaxPP = table.Column<double>(type: "float", nullable: false),
                    TaxCC = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueAgentPP = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueAgentCC = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueCarrierPP = table.Column<double>(type: "float", nullable: false),
                    TotalOtherChargesDueCarrierCC = table.Column<double>(type: "float", nullable: false),
                    TotalPrepaid = table.Column<double>(type: "float", nullable: false),
                    TotalCollect = table.Column<double>(type: "float", nullable: false),
                    CuCoRates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcChgsInDestCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChgsAtDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCcChgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuingPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingPersonFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    GrossWeight = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    ChargeableWeight = table.Column<double>(type: "float", nullable: false),
                    Commodity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipperPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ConsigneeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAddressC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneePhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Submitted = table.Column<bool>(type: "bit", nullable: false),
                    Processed = table.Column<bool>(type: "bit", nullable: false),
                    AgentSubmitShipperId = table.Column<int>(type: "int", nullable: true),
                    AgentSubmitConsigneeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentSubmitMawb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgentSubmitMawb_AgentSubmitConsignee_AgentSubmitConsigneeId",
                        column: x => x.AgentSubmitConsigneeId,
                        principalTable: "AgentSubmitConsignee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AgentSubmitMawb_AgentSubmitShipper_AgentSubmitShipperId",
                        column: x => x.AgentSubmitShipperId,
                        principalTable: "AgentSubmitShipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitDim_AgentSubmitModelId",
                table: "AgentSubmitDim",
                column: "AgentSubmitModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitHawb_AgentSubmitConsigneeId",
                table: "AgentSubmitHawb",
                column: "AgentSubmitConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitHawb_AgentSubmitShipperId",
                table: "AgentSubmitHawb",
                column: "AgentSubmitShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitMawb_AgentSubmitConsigneeId",
                table: "AgentSubmitMawb",
                column: "AgentSubmitConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitMawb_AgentSubmitShipperId",
                table: "AgentSubmitMawb",
                column: "AgentSubmitShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_AgentSubmitModel_SupplierId",
                table: "AgentSubmitModel",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentSubmitDim");

            migrationBuilder.DropTable(
                name: "AgentSubmitHawb");

            migrationBuilder.DropTable(
                name: "AgentSubmitMawb");

            migrationBuilder.DropTable(
                name: "AgentSubmitModel");

            migrationBuilder.DropTable(
                name: "AgentSubmitConsignee");

            migrationBuilder.DropTable(
                name: "AgentSubmitShipper");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "7b0899d7-5f68-4f9e-a08f-4faf4b9a4cb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f4c5056f-37b0-4b1a-85d2-36c18e5f1bc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4541f10-ce47-45bd-9e4d-c293ca4d0587", "AQAAAAEAACcQAAAAEG4XuNAafHhz+VwhT/2VCMdZXoLyfu74wIc1cHkrAbdBjMSRbEoCqIIxDrN7JPDUhA==", "205e0e42-eca3-404f-951c-d7942c4a6957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2f5945-77e1-45f1-8df9-81c703bac4c7", "AQAAAAEAACcQAAAAEBUJA7MDbFnMiwOe6RfA3qp0gYVziAsz+F/oDFj02V/L4aZwGcvbvRHJ56jgtQ+bTA==", "9b4dd1d1-7269-4834-97d3-70922a8b2b4d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 225, DateTimeKind.Local).AddTicks(3498), new DateTime(2022, 3, 2, 22, 1, 55, 227, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(226), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6402), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1513), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8465), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8489), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8492) });
        }
    }
}
