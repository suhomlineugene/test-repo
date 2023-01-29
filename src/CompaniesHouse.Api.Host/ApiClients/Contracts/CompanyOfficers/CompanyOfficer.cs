using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers
{
    public class CompanyOfficer
    {
        [JsonProperty("address")]
        public CompanyOfficerAddress CompanyOfficerAddress { get; set; }

        [JsonProperty("appointed_on")]
        public DateTime? AppointedOn { get; set; }

        [JsonProperty("country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty("date_of_birth")]
        public CompanyOfficerDateOfBirth CompanyOfficerDateOfBirth { get; set; }

        [JsonProperty("former_names")]
        public List<FormerName> FormerNames { get; set; }

        [JsonProperty("identification")]
        public CompanyOfficerIdentification CompanyOfficerIdentification { get; set; }

        public CompanyOfficerItemLinks Links { get; set; }
        public string Name { get; set; }

        public string Nationality { get; set; }

        public string Occupation { get; set; }

        [JsonProperty("officer_role")]
        public string OfficerRole { get; set; }

        [JsonProperty("resigned_on")]
        public DateTime? ResignedOn { get; set; }
    }
}