using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Pickup : BaseDomainModel
    {
        public string Name { get; set; }
        public string PickupAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime PickupDate { get; set; } = DateTime.Now;
        public decimal PickupAmount { get; set; } = 0;

        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual List<Arrival> Arrivals { get; set; }

    }
}
