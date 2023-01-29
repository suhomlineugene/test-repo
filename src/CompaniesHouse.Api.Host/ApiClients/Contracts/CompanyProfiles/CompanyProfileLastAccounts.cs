using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class CompanyProfileLastAccounts
    {
        [JsonProperty("made_up_to")]
        public DateTime? MadeUpTo { get; set; }
    }
}