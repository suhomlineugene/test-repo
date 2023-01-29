namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile
{
    public class PreviousCompanyNameDto
    {
        public DateTime? CeasedOn { get; set; }
        
        public DateTime? EffectiveFrom { get; set; }
        
        public string Name { get; set; }
    }
}