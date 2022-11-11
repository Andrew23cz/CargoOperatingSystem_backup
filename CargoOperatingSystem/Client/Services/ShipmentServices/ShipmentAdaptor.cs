using CargoOperatingSystem.Shared.Domain;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Navigations;
using System.Drawing;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Client.Services.ShipmentServices
{
    public class ShipmentAdaptor : DataAdaptor
    {
        private readonly IShipmentService _shipmentService;

        public ShipmentAdaptor (IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }
        public override async Task<object> ReadAsync (DataManagerRequest dm, string key = null)
        {
            GenericDataResult<Shipment> result = await _shipmentService.GetShipmentsPaged(dm.Skip, dm.Take);

            //result.Data = DataOperations.PerformSearching(result.Data, dataManagerRequest.Search);

            if (dm.Search != null && dm.Search.Count > 0)
            {
                // Searching
                result.Data = DataOperations.PerformSearching(result.Data, dm.Search);
            }
            if (dm.Sorted != null && dm.Sorted.Count > 0)
            {
                // Sorting
                result.Data = DataOperations.PerformSorting(result.Data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0)
            {
                // Filtering
                result.Data = DataOperations.PerformFiltering(result.Data, dm.Where, dm.Where[0].Operator);
            }

            DataResult dataResult = new DataResult()
            {
                Result = result.Data,
                Count = result.Count,
            };

            return dataResult;

        }
    }
}
