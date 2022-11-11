using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Arrival : BaseDomainModel
    {
        public DateTime ArrivalTime { get; set; } = DateTime.Now;
        public string ArrivalPoint { get; set; }
        public string DriverName { get; set; }
        public int? DriverPhone { get; set; }
        public string CarColour { get; set; }
        public string LicensePlate { get; set; }

        public string PickupAddress { get; set; }
        public DateTime PickupDate { get; set; } = DateTime.Now;
        public bool PickupCheck { get; set; } = false;
        public decimal PickupAmount { get; set; } = 0;

        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int? PickupId { get; set; }
        public virtual Pickup Pickup { get; set; }

        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
