using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class BranchCompanyDetails
    {
        [JsonProperty("business_activity")]
        public string BusinessActivity { get; set; }

        [JsonProperty("parent_company_name")]
        public string ParentCompanyName { get; set; }

        [JsonProperty("parent_company_number")]
        public string ParentCompanyNumber { get; set; }
    }
}