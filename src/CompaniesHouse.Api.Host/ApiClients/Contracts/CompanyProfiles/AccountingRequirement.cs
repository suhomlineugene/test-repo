using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class AccountingRequirement
    {
        [JsonProperty("foreign_account_type")]
        public string ForeignAccountType { get; set; }

        [JsonProperty("terms_of_account_publication")]
        public string TermsOfAccountPublication { get; set; }
    }
}