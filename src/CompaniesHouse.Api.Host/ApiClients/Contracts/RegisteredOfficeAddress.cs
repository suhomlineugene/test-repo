using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients.Contracts
{
    public class RegisteredOfficeAddress
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("care_of")]
        public string CareOf { get; set; }

        public string Country { get; set; }

        public string Locality { get; set; }

        [JsonProperty("po_box")]
        public string PoBox { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        public string Premises { get; set; }

        public string Region { get; set; }
    }
}