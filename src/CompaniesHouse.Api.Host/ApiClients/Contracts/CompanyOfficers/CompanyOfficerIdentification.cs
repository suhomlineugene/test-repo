using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers
{
    public class CompanyOfficerIdentification
    {
        [JsonProperty("identification_type")]
        public string IdentificationType { get; set; }

        [JsonProperty("legal_authority")]
        public string LegalAuthority { get; set; }

        [JsonProperty("legal_form")]
        public string LegalForm { get; set; }

        [JsonProperty("place_registered")]
        public string PlaceRegistered { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}