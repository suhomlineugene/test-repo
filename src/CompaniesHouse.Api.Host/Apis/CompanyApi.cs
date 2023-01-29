using CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficeAddress;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile;
using CompaniesHouse.Api.Host.Services;

namespace CompaniesHouse.Api.Host.Apis
{
    public class CompanyApi
    {
        public void Register(WebApplication app)
        {
            app.MapGet("/Company/GetProfile", GetByCompanyNumber);

            app.MapGet("/Company/GetOfficersPage", GetOfficersPage);

            app.MapGet("/Company/GetFilingHistoryPage", GetFilingHistoryPage);

            app.MapGet("/Company/GetOfficeAddress", GetOfficeAddress);
        }

        private async Task<CompanyProfileDto> GetByCompanyNumber(string companyNumber,
            ICompanyService companyService) =>
            await companyService.GetCompanyProfile(companyNumber);

        private async Task<CompanyOfficersDto> GetOfficersPage(string companyNumber,
            int itemsPerPage,int startIndex,
            ICompanyService companyService) =>
            await companyService.GetCompanyOfficersPage(companyNumber, itemsPerPage, startIndex);

        private async Task<CompanyFilingHistoryDto> GetFilingHistoryPage(string companyNumber,
            int itemsPerPage, int startIndex,
            ICompanyService companyService) =>
            await companyService.GetCompanyFilingHistoryPage(companyNumber, itemsPerPage, startIndex);

        private async Task<CompanyOfficeAddressDto> GetOfficeAddress(string companyNumber,
            ICompanyService companyService) =>
            await companyService.GetCompanyOfficeAddress(companyNumber);
    }
}
