namespace CargoOperatingSystem.Shared.Domain
{
    public class AwbStock : BaseDomainModel
    {
        public string AwbNumber { get; set; }
        public string AwbStatus { get; set; }
        

        public int AirlineId { get; set; }
        public virtual Airline Airline { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
        public virtual Shipment Shipment { get; set; }
        
        
    }
}
