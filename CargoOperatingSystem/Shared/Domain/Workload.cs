namespace CargoOperatingSystem.Shared.Domain
{
    public class Workload : BaseDomainModel
    {
        public decimal WorkloadAmount { get; set; }
        public int AwbIssuing { get; set; } = 0;
        public int HawbIssuing { get; set; } = 0;
        public int CargoLabels { get; set; } = 0;
        public int AcceptanceAssist { get; set; } = 0;
        public int DocumentsCorrection { get; set; } = 0;
        public int ImportCgoProcessing { get; set; } = 0;
        public int PrintingCorrectedDocs { get; set; } = 0;
        public int SpecCargoLabels { get; set; } = 0;
        public int AfterOpeningHoursService { get; set; } = 0;
        public int ManualDataInsertion { get; set; } = 0;
        public int PickUpDocuments { get; set; } = 0;
        public int SecurityCheckPrepare { get; set; } = 0;
        public int SecurityCheckAssist { get; set; } = 0;
        public int PackingAssist { get; set; } = 0;
        public int AcceptanceAssistDG { get; set; } = 0;
        public int CosultingDG { get; set; } = 0;
        
        public int AdditionalServiceA { get; set; } = 0;
        public int AdditionalServiceB { get; set; } = 0;
        public int AdditionalServiceC { get; set; } = 0;
        public int AdditionalServiceD { get; set; } = 0;
        public int AdditionalServiceE { get; set; } = 0;
        
        public string AdditionalServiceNoteA { get; set; }
        public string AdditionalServiceNoteB { get; set; }
        public string AdditionalServiceNoteC { get; set; }
        public string AdditionalServiceNoteD { get; set; }
        public string AdditionalServiceNoteE { get; set; }

        public int WorkloadRateSheetId { get; set; }
        public virtual WorkloadRateSheet WorkloadRateSheet { get; set; }

        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }

    }
}
