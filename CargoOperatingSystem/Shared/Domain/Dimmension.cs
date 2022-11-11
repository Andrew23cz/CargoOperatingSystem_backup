namespace CargoOperatingSystem.Shared.Domain
{
    public class Dimmension : BaseDomainModel
    {
        public int Pieces { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
