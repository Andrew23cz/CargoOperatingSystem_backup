using CargoOperatingSystem.Client.Static;
using CargoOperatingSystem.Shared.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Client.Services.ShipmentServices
{
    public class ShipmentService : IShipmentService
    {
        private readonly HttpClient _client;

        public ShipmentService (HttpClient client)
        {
            _client = client;
        }

        public IEnumerable<Shipment> Shipments { get; set; } = null;

        public async Task<GenericDataResult<Shipment>> GetShipmentsPaged (int skip, int take)
        {
            var result = await _client.GetFromJsonAsync<GenericDataResult<Shipment>>($"{Endpoints.ShipmentsEndpoint}?skip={skip}&take={take}");
            return result;
        }

        public async Task GetShipments()
        {
            var result = await _client.GetFromJsonAsync<GenericDataResult<Shipment>>(Endpoints.ShipmentsEndpoint);

            if(result.Data != null)
            {
                Shipments = result.Data;
            }
        }
    }
}
