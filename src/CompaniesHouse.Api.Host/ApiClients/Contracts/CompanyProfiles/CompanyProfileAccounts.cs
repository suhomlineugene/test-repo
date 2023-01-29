using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class CompanyProfileAccounts
    {
        [JsonProperty("accounting_reference_date")]
        public CompanyProfileAccount AccountingReferenceDate { get; set; }

        [JsonProperty("last_accounts")]
        public CompanyProfileLastAccounts CompanyProfileLastAccounts { get; set; }

        [JsonProperty("next_due")]
        public DateTime? NextDue { get; set; }

        [JsonProperty("next_made_up_to")]
        public DateTime? NextMadeUpTo { get; set; }

        public bool Overdue { get; set; }
    }
}