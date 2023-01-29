namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class CompanyProfileAnnualReturnDto
    {
        public DateTime? LastMadeUpTo { get; set; }
        
        public DateTime? NextDue { get; set; }
        
        public DateTime? NextMadeUpTo { get; set; }
        
        public bool Overdue { get; set; }
    }
}