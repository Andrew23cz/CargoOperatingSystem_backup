using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Shipment : BaseDomainModel
    {
        
        public string AwbNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Commodity { get; set; }

        public string ShcA { get; set; }
        public string ShcB { get; set; }
        public string ShcC { get; set; }

        public string HandlingInformationA { get; set; }
        public string HandlingInformationB { get; set; }
        public string HandlingInformationC { get; set; }

        public int Pieces { get; set; } = 0;
        public double GrossWeight { get; set; } = 0;
        public double Volume { get; set; } = 0;
        public double ChargeableWeight { get; set; } = 0;

        public DateTime BillingDate { get; set; } = DateTime.Today;
        public DateTime MawbIssuingDate { get; set; } = DateTime.Today;

        public string FirstFlightNumber { get; set; }
        public DateTime FirstFlightDate { get; set; } = DateTime.Today;
        public string FirstFlightDest { get; set; }

        public string SecondFlightNumber { get; set; }
        public DateTime SecondFlightDate { get; set; } = DateTime.Today;
        public string SecondFlightDest { get; set; }

        public string ThirdFlightNumber { get; set; }
        public DateTime ThirdFlightDate { get; set; } = DateTime.Today;
        public string ThirdFlightDest { get; set; }


        public string ShipmentStatus { get; set; } = "Created";
        
        public bool IsChecked { get; set; } = false;
        public bool IsInvoiced { get; set; } = false;

        public int AwbStockId { get; set; }
        public virtual AwbStock AwbStock { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int? DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }

        public virtual Arrival Arrival { get; set; }

        public virtual Workload Workload { get; set; }

        public virtual Mawb Mawb { get; set; }


        public virtual List<Dimmension> Dimmensions { get; set; }

        public virtual List<Charge> Charges { get; set; }







    }
}
