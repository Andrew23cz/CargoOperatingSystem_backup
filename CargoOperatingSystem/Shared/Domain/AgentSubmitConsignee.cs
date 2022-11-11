using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class AgentSubmitConsignee : BaseDomainModel
    {
        public string Name { get; set; }
        public string AddressA { get; set; }
        public string AddressB { get; set; }
        public string AddressC { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }


        public virtual List<AgentSubmitMawb> AgentSubmitMawbs { get; set; }
        public virtual List<AgentSubmitHawb> AgentSubmitHawbs { get; set; }
    }
}
