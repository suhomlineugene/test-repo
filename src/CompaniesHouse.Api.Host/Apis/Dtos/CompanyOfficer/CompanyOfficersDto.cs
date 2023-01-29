namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer
{
    public class CompanyOfficersDto
    {
        public long? ActiveCount { get; set; }
        
        public string Etag { get; set; }
        
        public List<CompanyOfficerDto> Items { get; set; }
        
        public long? ItemsPerPage { get; set; } 
        
        public string Kind { get; set; }
        
        public CompanyOfficerLinksDto Links { get; set; }
        
        public long? ResignedCount { get; set; }
        
        public long? StartIndex { get; set; }
        
        public long? TotalResults { get; set; }
    }
}