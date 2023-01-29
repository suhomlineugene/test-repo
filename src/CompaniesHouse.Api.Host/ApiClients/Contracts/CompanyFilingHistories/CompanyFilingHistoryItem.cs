using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories
{
    public class CompanyFilingHistoryItem
    {
        public List<Annotation> Annotations { get; set; }

        [JsonProperty("associated_filings")]
        public List<AssociatedFiling> AssociatedFilings { get; set; }

        public string Barcode { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("links")]
        public CompanyFilingHistoryLinks CompanyFilingHistoryLinks { get; set; }

        public long? Pages { get; set; }

        [JsonProperty("paper_filed")]
        public bool PaperFiled { get; set; }

        public List<Resolution> Resolutions { get; set; }

        public string Subcategory { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        public string Type { get; set; }
    }
}