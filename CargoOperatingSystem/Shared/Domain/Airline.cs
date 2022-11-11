using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Airline : BaseDomainModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Prefix { get; set; }
        public string AwbHeaderA { get; set; }
        public string AwbHeaderB { get; set; }
        public string BillingDateBasis { get; set; }

        public virtual List<AwbStock> AwbStocks { get; set; }

    }
}
