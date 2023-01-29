using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficeAddresses;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles;

namespace CompaniesHouse.Api.Host.ApiClients
{
    public interface ICompaniesHouseApiClient
    {
        Task<CompanyProfile> GetCompanyProfile(string companyNumber);

        Task<CompanyOfficeAddress> GetCompanyOfficeAddress(string companyNumber);

        Task<CompanyFilingHistory> GetCompanyFilingHistoryPage(string companyNumber, int itemsPerPage, int startIndex);

        Task<CompanyOfficers> GetCompanyOfficersPage(string companyNumber, int itemsPerPage, int startIndex);
    }
}
