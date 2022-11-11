using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Shared.Domain
{
    public class WorkloadRateSheet : BaseDomainModel
    {
        public string Name { get; set; }
        public decimal AwbIssuing { get; set; } = 0;
        public decimal HawbIssuing { get; set; } = 0;
        public decimal CargoLabels { get; set; } = 0;
        public decimal AcceptanceAssist { get; set; } = 0;
        public decimal DocumentsCorrection { get; set; } = 0;
        public decimal ImportCgoProcessing { get; set; } = 0;
        public decimal PrintingCorrectedDocs { get; set; } = 0;
        public decimal SpecCargoLabels { get; set; } = 0;
        public decimal AfterOpeningHoursService { get; set; } = 0;
        public decimal ManualDataInsertion { get; set; } = 0;
        public decimal PickUpDocuments { get; set; } = 0;
        public decimal SecurityCheckPrepare { get; set; } = 0;
        public decimal SecurityCheckAssist { get; set; } = 0;
        public decimal PackingAssist { get; set; } = 0;
        public decimal AcceptanceAssistDG { get; set; } = 0;
        public int CosultingDG { get; set; } = 0;

        public decimal AdditionalServiceA { get; set; } = 0;
        public decimal AdditionalServiceB { get; set; } = 0;
        public decimal AdditionalServiceC { get; set; } = 0;
        public decimal AdditionalServiceD { get; set; } = 0;
        public decimal AdditionalServiceE { get; set; } = 0;

        public string AdditionalServiceNoteA { get; set; }
        public string AdditionalServiceNoteB { get; set; }
        public string AdditionalServiceNoteC { get; set; }
        public string AdditionalServiceNoteD { get; set; }
        public string AdditionalServiceNoteE { get; set; }

        public string AwbIssuingCode { get; set; } = "mawb";
        public string HawbIssuingCode { get; set; } = "hawb";
        public string CargoLabelsCode { get; set; } = "label";
        public string AcceptanceAssistCode { get; set; } = "accept";
        public string DocumentsCorrectionCode { get; set; } = "doccorr";
        public string ImportCgoProcessingCode { get; set; } = "import";
        public string PrintingCorrectedDocsCode { get; set; } = "printdoccorr";
        public string SpecCargoLabelsCode { get; set; } = "spclabel";
        public string AfterOpeningHoursServiceCode { get; set; } = "afteropenhrs";
        public string ManualDataInsertionCode { get; set; } = "manualdata";
        public string PickUpDocumentsCode { get; set; } = "pickdoc";
        public string SecurityCheckPrepareCode { get; set; } = "secprep";
        public string SecurityCheckAssistCode { get; set; } = "secassist";
        public string PackingAssistCode { get; set; } = "pack";
        public string AcceptanceAssistDGCode { get; set; } = "acceptdg";
        public string CosultingDGCode { get; set; } = "consultdg";
        public string AdditionalServiceACode { get; set; } = "adda";
        public string AdditionalServiceBCode { get; set; } = "addb";
        public string AdditionalServiceCCode { get; set; } = "addc";
        public string AdditionalServiceDCode { get; set; } = "addd";
        public string AdditionalServiceECode { get; set; } = "adde";

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }


    }
}
