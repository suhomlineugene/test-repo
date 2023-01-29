using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class ForeignCompanyDetailsAccounts
    {
        [JsonProperty("account_period_from:")]
        public CompanyProfileAccount AccountPeriodFrom { get; set; }

        [JsonProperty("account_period_to")]
        public CompanyProfileAccount AccountPeriodTo { get; set; }

        [JsonProperty("must_file_within")]
        public MustFileWithin MustFileWithin { get; set; }
    }
}