using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories
{
    public class Annotation
    {
        [JsonProperty("annotation")]
        public string Value { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}