using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class ForeignCompanyDetails
    {
        [JsonProperty("accounting_requirement")]
        public AccountingRequirement AccountingRequirement { get; set; }
        public ForeignCompanyDetailsAccounts Accounts { get; set; }

        [JsonProperty("business_activity")]
        public string BusinessActivity { get; set; }

        [JsonProperty("company_type")]
        public string CompanyType { get; set; }

        [JsonProperty("governed_by")]
        public string GovernedBy { get; set; }

        [JsonProperty("is_a_credit_finance_institution")]
        public bool IsACreditFinanceInstitution { get; set; }

        [JsonProperty("originating_registry")]
        public OriginatingRegistry OriginatingRegistry { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}