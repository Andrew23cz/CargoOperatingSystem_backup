using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string CompanyName { get; set; }
        public string HqAddressA { get; set; }
        public string HqAddressB { get; set; }
        public string HqAddressC { get; set; }
        public string InvoicingAddressA { get; set; }
        public string InvoicingAddressB { get; set; }
        public string InvoicingAddressC { get; set; }
        public string TaxNumber { get; set; }
        public string ContactPersonName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string IataCode { get; set; }

        public virtual List<Shipment> Shipments { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
        public virtual List<AwbStock> AwbStocks { get; set; }



    }
}
