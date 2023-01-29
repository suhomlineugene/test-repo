using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers
{
    public class CompanyOfficers
    {
        [JsonProperty("active_count")]
        public long? ActiveCount { get; set; }

        public string Etag { get; set; }

        public List<CompanyOfficer> Items { get; set; }

        [JsonProperty("items_per_page")]
        public long? ItemsPerPage { get; set; }

        public string Kind { get; set; }

        public CompanyOfficerLinks Links { get; set; }

        [JsonProperty("resigned_count")]
        public long? ResignedCount { get; set; }

        [JsonProperty("start_index")]
        public long? StartIndex { get; set; }

        [JsonProperty("total_results")]
        public long? TotalResults { get; set; }
    }
}