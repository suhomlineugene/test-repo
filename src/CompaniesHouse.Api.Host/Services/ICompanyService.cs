using CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficeAddress;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile;

namespace CompaniesHouse.Api.Host.Services
{
    public interface ICompanyService
    {
        Task<CompanyProfileDto> GetCompanyProfile(string companyNumber);

        Task<CompanyOfficersDto> GetCompanyOfficersPage(string companyNumber, int itemsPerPage, int startIndex);

        Task<CompanyFilingHistoryDto> GetCompanyFilingHistoryPage(string companyNumber, int itemsPerPage, int startIndex);

        Task<CompanyOfficeAddressDto> GetCompanyOfficeAddress(string companyNumber);
    }
}
