namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class ForeignCompanyDetailsDto
    {
        public AccountingRequirementDto AccountingRequirementDto { get; set; }
        
        public ForeignCompanyDetailsAccountsDto AccountsDto { get; set; }
        
        public string BusinessActivity { get; set; }
        
        public string CompanyType { get; set; }
        
        public string GovernedBy { get; set; }
        
        public bool IsACreditFinanceInstitution { get; set; }
        
        public OriginatingRegistryDto OriginatingRegistryDto { get; set; }
        
        public string RegistrationNumber { get; set; }
    }
}