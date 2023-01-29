namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class CompanyProfileAccountsDto
    {
        public CompanyProfileAccountDto AccountingReferenceDate { get; set; }
        
        public CompanyProfileLastAccountsDto LastAccounts { get; set; }
        
        public DateTime? NextDue { get; set; }
        
        public DateTime? NextMadeUpTo { get; set; }
        
        public bool Overdue { get; set; }
    }
}