using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Supplier : BaseDomainModel
    {
        public string SupplierType { get; set; }
        public string CompanyName { get; set; }
        public string HqAddress { get; set; }
        public string InvoicingAddress { get; set; }
        public string TaxNumber { get; set; }
        public string ContactPersonName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public virtual List<Arrival> Arrivals { get; set; }
        public virtual List<Charge> Charges { get; set; }
    }
}
