using System;
using System.Collections.Generic;

namespace CargoOperatingSystem.Shared.Domain
{
    public class AgentSubmitModel : BaseDomainModel
    {
        public string AwbNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Commodity { get; set; }
        public int Pieces { get; set; } = 0;
        public double GrossWeight { get; set; } = 0;
        public double Volume { get; set; } = 0;
        public double ChargeableWeight { get; set; } = 0;

        public string ShcA { get; set; }
        public string ShcB { get; set; }
        public string ShcC { get; set; }

        public string HandlingInformationA { get; set; }
        public string HandlingInformationB { get; set; }
        public string HandlingInformationC { get; set; }

        public string FirstFlightNumber { get; set; }
        public DateTime FirstFlightDate { get; set; } = DateTime.Today;
        public string FirstFlightDest { get; set; }
        public string SecondFlightNumber { get; set; }
        public DateTime SecondFlightDate { get; set; } = DateTime.Today;
        public string SecondFlightDest { get; set; }
        public string ThirdFlightNumber { get; set; }
        public DateTime ThirdFlightDate { get; set; } = DateTime.Today;
        public string ThirdFlightDest { get; set; }

        public DateTime ArrivalTime { get; set; } = DateTime.Now;
        public string ArrivalPoint { get; set; }
        public string ArrivalDriverName { get; set; }
        public int? ArrivalDriverPhone { get; set; }
        public string ArrivalCarColour { get; set; }
        public string ArrivalLicensePlate { get; set; }

        public string PickupAddress { get; set; }
        public string PickupDeliveryAddress { get; set; }
        public DateTime PickupDate { get; set; } = DateTime.Now;

        public bool WorkloadAwbIssuing { get; set; } = false;
        public bool WorkloadHawbIssuing { get; set; } = false;
        public bool WorkloadCargoLabels { get; set; } = false;
        public bool WorkloadAcceptanceAssist { get; set; } = false;
        public bool WorkloadDocumentsCorrection { get; set; } = false;
        public bool WorkloadImportCgoProcessing { get; set; } = false;
        public bool WorkloadPrintingCorrectedDocs { get; set; } = false;
        public bool WorkloadSpecCargoLabels { get; set; } = false;
        public bool WorkloadAfterOpeningHoursService { get; set; } = false;
        public bool WorkloadManualDataInsertion { get; set; } = false;
        public bool WorkloadPickUpDocuments { get; set; } = false;
        public bool WorkloadSecurityCheckPrepare { get; set; } = false;
        public bool WorkloadSecurityCheckAssist { get; set; } = false;
        public bool WorkloadPackingAssist { get; set; } = false;
        public bool WorkloadAcceptanceAssistDG { get; set; } = false;
        public bool WorkloadConsultingDG { get; set; } = false;
        public bool WorkloadAdditionalServiceA { get; set; } = false;
        public bool WorkloadAdditionalServiceB { get; set; } = false;
        public bool WorkloadAdditionalServiceC { get; set; } = false;
        public bool WorkloadAdditionalServiceD { get; set; } = false;
        public bool WorkloadAdditionalServiceE { get; set; } = false;
        

        public string WorkloadAwbIssuingNote { get; set; }
        public string WorkloadHawbIssuingNote { get; set; }
        public string WorkloadCargoLabelsNote { get; set; }
        public string WorkloadAcceptanceAssistNote { get; set; }
        public string WorkloadImportCgoProcessingNote { get; set; }
        public string WorkloadSpecCargoLabelsNote { get; set; }
        public string WorkloadManualDataInsertionNote { get; set; }
        public string WorkloadPickUpDocumentsNote { get; set; }
        public string WorkloadSecurityCheckPrepareNote { get; set; }
        public string WorkloadSecurityCheckAssistNote { get; set; }
        public string WorkloadPackingAssistNote { get; set; }
        public string WorkloadAcceptanceAssistDGNote { get; set; }
        public string WorkloadAdditionalServiceNoteA { get; set; }
        public string WorkloadAdditionalServiceNoteB { get; set; }
        public string WorkloadAdditionalServiceNoteC { get; set; }
        public string WorkloadAdditionalServiceNoteD { get; set; }
        public string WorkloadAdditionalServiceNoteE { get; set; }

        public bool Submitted { get; set; } = false;
        public DateTime SubmitTime { get; set; }
        public bool Processed { get; set; } = false;
        public DateTime ProcessedTime { get; set; }
        public bool Rejected { get; set; } = false;
        public DateTime RejectTime { get; set; }

        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<AgentSubmitDim> AgentSubmitDims { get; set; }
    }
}
