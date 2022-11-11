using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class Shipper : BaseDomainModel
    {
        public string Name { get; set; }
        public string AddressA { get; set; }
        public string AddressB { get; set; }
        public string AddressC { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public virtual List<Mawb> Mawbs { get; set; }
        public virtual List<Hawb> Hawbs { get; set; }


    }
}
