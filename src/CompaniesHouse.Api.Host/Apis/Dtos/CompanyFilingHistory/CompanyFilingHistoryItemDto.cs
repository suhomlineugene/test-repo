namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory
{
    public class CompanyFilingHistoryItemDto
    {
        public List<AnnotationDto> Annotations { get; set; }
        
        public List<AssociatedFilingDto> AssociatedFilings { get; set; }
        
        public string Barcode { get; set; }
        
        public string Category { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Description { get; set; }
        
        public CompanyFilingHistoryLinksDto CompanyFilingHistoryLinksDto { get; set; }
        
        public long? Pages { get; set; }
        
        public bool PaperFiled { get; set; }
        
        public List<ResolutionDto> Resolutions { get; set; }
        
        public string Subcategory { get; set; }
        
        public string TransactionId { get; set; }
        
        public string Type { get; set; }
    }
}