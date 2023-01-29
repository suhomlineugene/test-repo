namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory
{
    public class CompanyFilingHistoryDto
    {
        public string Etag { get; set; }
        
        public string FilingHistoryStatus { get; set; }
        
        public List<CompanyFilingHistoryItemDto> Items { get; set; }
        
        public long? ItemsPerPage { get; set; }
        
        public string Kind { get; set; }
        
        public long? StartIndex { get; set; }
        
        public long? TotalCount { get; set; }
    }
}