using CargoOperatingSystem.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Client.Services.ShipmentServices
{
    public interface IShipmentService
    {
        public IEnumerable<Shipment> Shipments { get; set; }
        public Task<GenericDataResult<Shipment>> GetShipmentsPaged(int skip, int take);
        public Task GetShipments();
    }
}
