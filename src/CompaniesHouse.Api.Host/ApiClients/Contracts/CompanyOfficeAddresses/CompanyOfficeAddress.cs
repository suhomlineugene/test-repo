using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficeAddresses
{
    public class CompanyOfficeAddress : RegisteredOfficeAddress
    {
        [JsonProperty("links")]
        public CompanyOfficeLinks CompanyOfficeLinks { get; set; }
    }
}