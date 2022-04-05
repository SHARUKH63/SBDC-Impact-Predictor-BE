using System;

namespace SbdcImpactPredictor.Models.ApiModels
{
    public class Loan
    {
        public string UniqueIdentifier { get; set; }
        public string CreditType { get; set; }
        public int AmountApplied { get; set; }
        public int AmountApproved { get; set; }
        public DateTime ActionTakenDate { get; set; }
        public string Status { get; set; }
        public string DenialInformation { get; set; }
        public string MinorityOwned { get; set; }
        public string Gender { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string State { get; set; }
    }
}