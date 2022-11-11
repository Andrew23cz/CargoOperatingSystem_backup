using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Currency : BaseDomainModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Symbol { get; set; }
        public string SymbolCode { get; set; }

        public virtual List<Charge> Charges { get; set; }

        public virtual List<ChargeTemplate> ChargeTemplates { get; set; }

        public virtual List<AfRates> AfRates { get; set; }

        public virtual List<WorkloadRateSheet> WorkloadRateSheets { get; set; }

    }
}
