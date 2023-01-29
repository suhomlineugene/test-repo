using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories
{
    public class CompanyFilingHistoryLinks
    {
        [JsonProperty("document_metadata")]
        public string DocumentMetadata { get; set; }

        public string Self { get; set; }
    }
}