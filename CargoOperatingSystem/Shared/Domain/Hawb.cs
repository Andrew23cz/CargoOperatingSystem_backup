using System;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Hawb : BaseDomainModel
    {
        public string HawbNumber { get; set; }
        public string AwbNumber { get; set; }

        public string IssuingAgent { get; set; }
        public string IssuingAgentCity { get; set; }
        public string IssuingAgentAddressA { get; set; }
        public string IssuingAgentAddressB { get; set; }
        public string IssuingAgentAddressC { get; set; }
        public string AgentIataCode { get; set; }
        public string AgentAccountNumber { get; set; }

        public string FirstCarrierCode { get; set; }
        public string SecondCarrierCode { get; set; }
        public string ThirdCarrierCode { get; set; }
        public string FirstFlightDest { get; set; }
        public string SecondFlightDest { get; set; }
        public string ThirdFlightDest { get; set; }
        public string FirstFlightNoAndDate { get; set; }
        public string SecondFlightNoAndDate { get; set; }
        public string ThirdFlightNoAndDate { get; set; }
        public string HandlingInfoA { get; set; }
        public string HandlingInfoB { get; set; }
        public string HandlingInfoC { get; set; }
        public string Sci { get; set; } = "X";
        public string AirlineName { get; set; }
        public string AirlineAddressA { get; set; }
        public string AirlineAddressB { get; set; }
        public string AccountingInfoA { get; set; }
        public string AccountingInfoB { get; set; }
        public string AccountingInfoC { get; set; }
        public string ReferenceNo { get; set; }
        public string OptionalShippingInfoA { get; set; }
        public string OptionalShippingInfoB { get; set; }
        public string Currency { get; set; } = "CZK";
        public string ChgsCode { get; set; } = "PP";
        public string WtValPP { get; set; } = "P";
        public string WtValCOL { get; set; }
        public string OtherChgsCodePP { get; set; } = "P";
        public string OtherChgsCodeCOL { get; set; }

        public string DeclaredValueCarriage { get; set; } = "NVD";
        public string DeclaredValueCustoms { get; set; } = "NCV";
        public string AmountOfInsurance { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }

        public string RateClass { get; set; }
        public string CommodityItemNo { get; set; }
        public double RateCharge { get; set; } = 0;
        public double TotalCharge { get; set; } = 0;
        public string NatureAndQttyGoodsA { get; set; }
        public string NatureAndQttyGoodsB { get; set; }
        public string NatureAndQttyGoodsC { get; set; }
        public string NatureAndQttyGoodsD { get; set; }
        public string NatureAndQttyGoodsE { get; set; }
        public string NatureAndQttyGoodsF { get; set; }
        public string NatureAndQttyGoodsG { get; set; }
        public string NatureAndQttyGoodsH { get; set; }
        public string NatureAndQttyGoodsI { get; set; }
        public string NatureAndQttyGoodsJ { get; set; }
        public string OtherChargeA { get; set; }
        public string OtherChargeB { get; set; }
        public string OtherChargeC { get; set; }
        public string OtherChargeD { get; set; }
        public double WeightChargePP { get; set; } = 0;
        public double WeightChargeCC { get; set; } = 0;
        public double ValuationChargePP { get; set; } = 0;
        public double ValuationChargeCC { get; set; } = 0;
        public double TaxPP { get; set; } = 0;
        public double TaxCC { get; set; } = 0;
        public double TotalOtherChargesDueAgentPP { get; set; } = 0;
        public double TotalOtherChargesDueAgentCC { get; set; } = 0;
        public double TotalOtherChargesDueCarrierPP { get; set; } = 0;
        public double TotalOtherChargesDueCarrierCC { get; set; } = 0;
        public double TotalPrepaid { get; set; } = 0;
        public double TotalCollect { get; set; } = 0;

        public string CuCoRates { get; set; }
        public string CcChgsInDestCurrency { get; set; }
        public string ChgsAtDest { get; set; }
        public string TotalCcChgs { get; set; }

        public DateTime IssuingDate { get; set; } = DateTime.Now;
        public string IssuingPlace { get; set; }
        public string IssuingPersonFullName { get; set; }

        public int Pieces { get; set; } = 0;
        public double GrossWeight { get; set; } = 0;
        public double Volume { get; set; } = 0;
        public double ChargeableWeight { get; set; } = 0;
        public string Commodity { get; set; }

        public string ShipperName { get; set; }
        public string ShipperAddressA { get; set; }
        public string ShipperAddressB { get; set; }
        public string ShipperAddressC { get; set; }
        public string ShipperEmail { get; set; }
        public int ShipperPhoneNumber { get; set; }

        public string ConsigneeName { get; set; }
        public string ConsigneeAddressA { get; set; }
        public string ConsigneeAddressB { get; set; }
        public string ConsigneeAddressC { get; set; }
        public string ConsigneeEmail { get; set; }
        public int ConsigneePhoneNumber { get; set; }

        public int MawbId { get; set; }
        public virtual Mawb Mawb { get; set; }


        public int ShipperId { get; set; }
        public virtual Shipper Shipper { get; set; }

        public int ConsigneeId { get; set; }
        public virtual Consignee Consignee { get; set; }
        
    }
}
