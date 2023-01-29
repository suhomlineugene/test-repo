using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles
{
    public class CompanyProfile
    {
        public CompanyProfileAccounts Accounts { get; set; }

        [JsonProperty("annual_return")]
        public CompanyProfileAnnualReturn AnnualReturn { get; set; }

        [JsonProperty("branch_company_details")]
        public BranchCompanyDetails BranchCompanyDetails { get; set; }

        [JsonProperty("can_file")]
        public bool CanFile { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("company_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompanyStatusEnum CompanyStatus { get; set; }

        [JsonProperty("company_status_detail")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompanyStatusDetailEnum CompanyStatusDetail { get; set; }

        [JsonProperty("confirmation_statement")]
        public CompanyProfileAnnualReturn ConfirmationStatement { get; set; }

        [JsonProperty("date_of_cessation")]
        public DateTime? DateOfCessation { get; set; }

        [JsonProperty("date_of_creation")]
        public DateTime? DateOfCreation { get; set; }

        public string Etag { get; set; }

        [JsonProperty("foreign_company_details")]
        public ForeignCompanyDetails ForeignCompanyDetails { get; set; }

        [JsonProperty("has_been_liquidated")]
        public bool HasBeenLiquidated { get; set; }

        [JsonProperty("has_charges")]
        public bool HasCharges { get; set; }

        [JsonProperty("has_insolvency_history")]
        public bool HasInsolvencyHistory { get; set; }

        [JsonProperty("is_community_interest_company")]
        public bool IsCommunityInterestCompany { get; set; }

        public string Jurisdiction { get; set; }

        [JsonProperty("last_full_members_list_date")]
        public DateTime? LastFullMembersListDate { get; set; }

        public CompanyProfileLinks CompanyProfileLinks { get; set; }

        [JsonProperty("previous_company_names")]
        public List<PreviousCompanyName> PreviousCompanyNames { get; set; }

        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress RegisteredOfficeAddress { get; set; }

        [JsonProperty("registered_office_is_in_dispute")]
        public bool RegisteredOfficeIsInDispute { get; set; }

        [JsonProperty("sic_codes")]
        public List<string> SicCodes { get; set; }

        public string Type { get; set; }

        [JsonProperty("undeliverable_registered_office_address")]
        public bool UndeliverableRegisteredOfficeAddress { get; set; }
    }
}