using System;

namespace SbdcImpactPredictor.Models.ApiModels
{
    public class Loan
    {
        public string UniqueIdentifier { get; set; }
        public CreditType CreditType { get; set; }
        public int AmountApplied { get; set; }
        public int AmountApproved { get; set; }
        public DateTime ActionTakenDate { get; set; }
        public LoanStatus Status { get; set; }
        public DenialReason DenialInformation { get; set; }
        public bool MinorityOwned { get; set; }
        public string Gender { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string State { get; set; }
    }
}