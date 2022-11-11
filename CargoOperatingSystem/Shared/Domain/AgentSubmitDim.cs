namespace CargoOperatingSystem.Shared.Domain
{
    public class AgentSubmitDim : BaseDomainModel
    {
        public int Pieces { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public int AgentSubmitModelId { get; set; }
        public virtual AgentSubmitModel AgentSubmitModel { get; set; }
    }
}
