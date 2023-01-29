using AutoMapper;
using CompaniesHouse.Api.Host.ApiClients;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyFilingHistory;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficeAddress;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyOfficer;
using CompaniesHouse.Api.Host.Apis.Dtos.CompanyProfile;
using CompaniesHouse.Api.Host.Data;
using CompaniesHouse.Api.Host.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CompaniesHouse.Api.Host.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<CompanyService> _logger;
        private readonly ICompaniesHouseApiClient _companiesHouseApiClient;
        private readonly IMapper _mapper;

        public CompanyService(AppDbContext appDbContext,
            ILogger<CompanyService> logger,
            ICompaniesHouseApiClient companiesHouseApiClient,
            IMapper mapper)
        {
            _appDbContext = appDbContext;
            _logger = logger;
            _companiesHouseApiClient = companiesHouseApiClient;
            _mapper = mapper;
        }

        public async Task<CompanyProfileDto> GetCompanyProfile(string companyNumber)
        {
            var companyProfileDto = new CompanyProfileDto();

            try
            {
                var companyProfile = await _companiesHouseApiClient.GetCompanyProfile(companyNumber);

                if (companyProfile == null)
                    throw new NotFoundException($"Company with number: {companyNumber} not found");

                companyProfileDto = _mapper.Map<CompanyProfileDto>(companyProfile);
            }
            catch (Exception)
            {
                companyProfileDto = await GetCompanyModelFromDb(companyNumber);
            }

            return companyProfileDto;
        }

        private async Task<CompanyProfileDto> GetCompanyModelFromDb(string companyNumber)
        {
            _logger.LogInformation("Get company profile from CompanyHouseDb");

            var companyModel = await _appDbContext.Companies
                .FirstOrDefaultAsync(x => x.CompanyNumber == companyNumber);

            if (companyModel == null)
            {
                var exceptionMessage = $"Company: {companyNumber} not found in database";

                _logger.LogError(exceptionMessage);

                throw new NotFoundException(exceptionMessage);
            }

            var companyProfileDto = _mapper.Map<CompanyProfileDto>(companyModel);

            return companyProfileDto;
        }

        public async Task<CompanyOfficersDto> GetCompanyOfficersPage(string companyNumber, int itemsPerPage, int startIndex)
        {
            _logger.LogInformation("Get Company Officers from Company House Api");

            var companyOfficers = await _companiesHouseApiClient.GetCompanyOfficersPage(companyNumber, itemsPerPage, startIndex);

            var companyOfficersDto = _mapper.Map<CompanyOfficersDto>(companyOfficers);

            return companyOfficersDto;
        }

        public async Task<CompanyFilingHistoryDto> GetCompanyFilingHistoryPage(string companyNumber, int itemsPerPage, int startIndex)
        {
            _logger.LogInformation("Get Company Filing History from Company House Api");

            var companyFilingHistory = await _companiesHouseApiClient.GetCompanyFilingHistoryPage(companyNumber, itemsPerPage, startIndex);

            var companyFilingHistoryDto = _mapper.Map<CompanyFilingHistoryDto>(companyFilingHistory);

            return companyFilingHistoryDto;
        }

        public async Task<CompanyOfficeAddressDto> GetCompanyOfficeAddress(string companyNumber)
        {
            _logger.LogInformation("Get Company Office Address from Company House Api");

            var companyOfficeAddress = await _companiesHouseApiClient.GetCompanyOfficeAddress(companyNumber);

            var companyOfficeAddressDto = _mapper.Map<CompanyOfficeAddressDto>(companyOfficeAddress);

            return companyOfficeAddressDto;
        }
    }
}
