using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class CompanyProfileLinks
    {
        [JsonProperty("persons_with_significant_control")]
        public string PersonsWithSignificantControl { get; set; }

        [JsonProperty("persons_with_significant_control_statements")]
        public string PersonsWithSignificantControlStatements { get; set; }

        public string Registers { get; set; }

        public string Self { get; set; }
    }
}