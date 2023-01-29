using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories
{
    public class Resolution
    {
        public string Category { get; set; }

        public string Description { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("receive_date")]
        public DateTime ReceiveDate { get; set; }

        public string Subcategory { get; set; }

        public string Type { get; set; }
    }
}