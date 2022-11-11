using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Shared.Domain
{
    public class ShipmentDataResult
    {
        public IEnumerable<Shipment> Shipments { get; set; }
        public int Count { get; set; }
    }
}
