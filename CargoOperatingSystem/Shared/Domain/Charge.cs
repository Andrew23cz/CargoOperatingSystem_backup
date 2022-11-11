namespace CargoOperatingSystem.Shared.Domain
{
    public class Charge : BaseDomainModel
    {
        public string ChargeName { get; set; }
        public string ChargeDue { get; set; }
        public decimal Amount { get; set; }
        public string ChargeType { get; set; }
        public string Note { get; set; }
        public string OtherChargeCode { get; set; }
        public string BuyingSelling { get; set; }
        public bool AutoPopulated { get; set; } = false;
        public string AutoPopulateCode { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
