namespace SbdcImpactPredictor.Models.ApiModels
{
    public enum DenialReason
    {
        CreditCharacteristicsOfBusiness = 0,
        CreditCharacteristicsOfPrincipalOwnerOrGuarantor = 1,
        UseOfLoanProceeds = 2,
        Cashflow = 3,
        Collateral = 4,
        TimeInbusiness = 5,
        GovernmentCriteria = 6,
        AggregateExposure = 7,
        UnverifiableInformation = 8,
        Other = 9
    }
}