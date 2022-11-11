using System;

namespace CargoOperatingSystem.Shared.Domain
{
    public class AfRates : BaseDomainModel
    {
        public string AccountName { get; set; }
        public string AirlineName { get; set; }
        public string CurrencyCode { get; set; }
        public string NewChange { get; set; }
        public string CountryDesignator { get; set; }
        public string IataNo { get; set; } = "ALL";
        public string CassNo { get; set; } = "ALL";
        public string DestinationCityName { get; set; }
        public string DestinationCityCode { get; set; }
        public string DestinationAirportCode { get; set; }
        public string DestinationCountryIsoCode { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierPrefix { get; set; }
        public string GsaName { get; set; }
        public string ProductName { get; set; } = "GCR";
        public string Dgr { get; set; }
        public string PrepaidRate { get; set; } = "y";
        public string CollectRate { get; set; } = "n";
        public DateTime EffectiveFrom { get; set; } = DateTime.Now;
        public DateTime EffectiveTo { get; set; } = DateTime.Now;
        public string OriginCountryCode { get; set; }
        public string OriginAirportCode { get; set; }
        public decimal? MinimumRate { get; set; }
        public decimal? NormalFlatRate { get; set; }
        public decimal? RateWeightBreak45 { get; set; }
        public decimal? RateWeightBreak100 { get; set; }
        public decimal? RateWeightBreak250 { get; set; }
        public decimal? RateWeightBreak300 { get; set; }
        public decimal? RateWeightBreak500 { get; set; }
        public decimal? RateWeightBreak1000 { get; set; }
        public string UldName { get; set; }
        public decimal? PivotWeight { get; set; }
        public decimal? PivotRate { get; set; }
        public decimal? FlatPrice { get; set; }
        public decimal? OverPivotRate { get; set; }
        public string Notes { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public int AirlineId { get; set; }
        public virtual Airline Airline { get; set; }



    }
}
