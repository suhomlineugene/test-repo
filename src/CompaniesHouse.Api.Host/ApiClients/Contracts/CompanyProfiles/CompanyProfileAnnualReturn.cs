using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class CompanyProfileAnnualReturn
    {
        [JsonProperty("last_made_up_to")]
        public DateTime? LastMadeUpTo { get; set; }

        [JsonProperty("next_due")]
        public DateTime? NextDue { get; set; }

        [JsonProperty("next_made_up_to")]
        public DateTime? NextMadeUpTo { get; set; }

        public bool Overdue { get; set; }
    }
}