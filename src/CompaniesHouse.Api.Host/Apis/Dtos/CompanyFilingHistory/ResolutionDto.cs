namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory
{
    public class ResolutionDto
    {
        public string Category { get; set; }
        
        public string Description { get; set; }
        
        public string DocumentId { get; set; }
        
        public DateTime ReceiveDate { get; set; }
        
        public string Subcategory { get; set; }
        
        public string Type { get; set; }
    }
}