using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Invoice : BaseDomainModel
    {
        public decimal InvoiceAmount { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime DuzpDate { get; set; }
        public DateTime DueDate { get; set; }

        public int CustomerId {get; set;}
        public virtual Customer Customer { get; set; }
        public virtual List<Shipment> Shipments { get; set; }


    }
}
