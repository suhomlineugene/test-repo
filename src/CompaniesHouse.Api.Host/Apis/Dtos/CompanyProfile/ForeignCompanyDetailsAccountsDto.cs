namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class ForeignCompanyDetailsAccountsDto
    {
        public CompanyProfileAccountDto AccountPeriodFrom { get; set; }
        
        public CompanyProfileAccountDto AccountPeriodTo { get; set; }
        
        public MustFileWithinDto MustFileWithinDto { get; set; }
    }
}