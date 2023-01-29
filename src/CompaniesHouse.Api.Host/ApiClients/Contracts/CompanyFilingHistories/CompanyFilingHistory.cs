using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories
{
    public class CompanyFilingHistory
    {
        public string Etag { get; set; }

        [JsonProperty("filing_history_status")]
        public string FilingHistoryStatus { get; set; }

        public List<CompanyFilingHistoryItem> Items { get; set; }

        [JsonProperty("items_per_page")]
        public long? ItemsPerPage { get; set; }

        public string Kind { get; set; }

        [JsonProperty("start_index")]
        public long? StartIndex { get; set; }

        [JsonProperty("total_count")]
        public long? TotalCount { get; set; }
    }
}