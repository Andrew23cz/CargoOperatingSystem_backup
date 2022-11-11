using System;
using System.Collections.Generic;



namespace CargoOperatingSystem.Shared.Domain
{
    public class Delivery : BaseDomainModel
    {
        public string OrderNumber { get; set; }
        public string LoadAddress { get; set; }
        public string OffloadAddress { get; set; }
        public DateTime LoadDate { get; set; }
        public DateTime OffloadDate { get; set; }
        public string OriginCode { get; set; }
        public string DestCode { get; set; }
        public string DriverName { get; set; }
        public int DriverPhone { get; set; }
        public string LicensePlate { get; set; }
        public decimal DeliveryAmount { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<Shipment> Shipments { get; set; }

        
        

        
    }
}
