using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Shared.Domain
{
    public class GenericDataResult<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int Count { get; set; }
    }
}
