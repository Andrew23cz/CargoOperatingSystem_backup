namespace CargoOperatingSystem.Shared.Domain
{
    public class ChargeTemplate : BaseDomainModel
    {
        public string TemplateName { get; set; }
        public string ChargeName { get; set; }
        public string ChargeDue { get; set; }
        public decimal Amount { get; set; }
        public string ChargeType { get; set; }
        public string Note { get; set; }
        public string OtherChargeCode { get; set; }
        public string BuyingSelling { get; set; }

        public string OriginAirport { get; set; }
        public string DestinationAirport { get; set; }
        public string ShcCode { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int? AirlineId { get; set; }
        public virtual Airline Airline { get; set; }

    }
}
