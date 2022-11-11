namespace CargoOperatingSystem.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public string OrderNumber { get; set; }
        public decimal OrderAmount { get; set; }


    }
}
