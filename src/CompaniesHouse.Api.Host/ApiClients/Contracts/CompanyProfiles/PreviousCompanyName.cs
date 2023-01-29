using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class PreviousCompanyName
    {
        [JsonProperty("ceased_on")]
        public DateTime? CeasedOn { get; set; }

        [JsonProperty("effective_from")]
        public DateTime? EffectiveFrom { get; set; }
        public string Name { get; set; }
    }
}