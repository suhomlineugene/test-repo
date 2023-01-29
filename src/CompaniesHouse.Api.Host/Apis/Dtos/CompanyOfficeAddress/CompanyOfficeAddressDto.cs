namespace CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficeAddress
{
    public class CompanyOfficeAddressDto : RegisteredOfficeAddressDto
    {
        public CompanyOfficeLinksDto CompanyOfficeLinks { get; set; }
    }
}