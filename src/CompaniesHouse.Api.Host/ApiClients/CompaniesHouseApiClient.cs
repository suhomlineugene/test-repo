using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyFilingHistories;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficeAddresses;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyOfficers;
using CompaniesHouse.Api.Host.ApiClients.Contracts.CompanyProfiles;
using CompaniesHouse.Api.Host.Exceptions;
using Newtonsoft.Json;

namespace CompaniesHouse.Api.Host.ApiClients
{
    public class CompaniesHouseApiClient : ICompaniesHouseApiClient
    {
        private readonly ILogger<CompaniesHouseApiClient> _logger;
        private readonly HttpClient _httpClient;

        public CompaniesHouseApiClient(ILogger<CompaniesHouseApiClient> logger,
            HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<CompanyProfile> GetCompanyProfile(string companyNumber)
        {
            HttpResponseMessage response;

            try
            {
                response = await _httpClient.GetAsync($"/company/{companyNumber}");
            }
            catch (TaskCanceledException ex)
            {
                throw new CompaniesHouseApiServerException(ex.Message);
            }

            if (!response.IsSuccessStatusCode)
            {
                ProceedUnsuccesfulResponse(response, "company profile");
            }

            var result = await ReadResponseAsAsync<CompanyProfile>(response);

            return result;
        }

        public async Task<CompanyOfficeAddress> GetCompanyOfficeAddress(string companyNumber)
        {
            HttpResponseMessage response;

            try
            {
                response = await _httpClient.GetAsync($"/company/{companyNumber}/registered-office-address");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to get company office address");
                throw new CompaniesHouseApiServerException(ex.Message);
            }

            if (!response.IsSuccessStatusCode)
            {
                ProceedUnsuccesfulResponse(response, "company office address");
            }

            var result = await ReadResponseAsAsync<CompanyOfficeAddress>(response);

            return result;
        }

        public async Task<CompanyFilingHistory> GetCompanyFilingHistoryPage(string companyNumber, int itemsPerPage, int startIndex)
        {
            HttpResponseMessage response;

            try
            {
                response = await _httpClient.GetAsync($"/company/{companyNumber}/filing-history?items_per_page={itemsPerPage}&start_index={startIndex}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to get company filing history");
                throw new CompaniesHouseApiServerException(ex.Message);
            }

            if (!response.IsSuccessStatusCode)
            {
                ProceedUnsuccesfulResponse(response, "company filing history");
            }

            var result = await ReadResponseAsAsync<CompanyFilingHistory>(response);

            return result;
        }

        public async Task<CompanyOfficers> GetCompanyOfficersPage(string companyNumber, int itemsPerPage, int startIndex)
        {
            HttpResponseMessage response;

            try
            {
                response = await _httpClient.GetAsync($"/company/{companyNumber}/officers?items_per_page={itemsPerPage}&start_index={startIndex}");

                var test = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to get company officers");
                throw new CompaniesHouseApiServerException(ex.Message);
            }

            if (!response.IsSuccessStatusCode)
            {
                ProceedUnsuccesfulResponse(response, "company officers");
            }

            var result = await ReadResponseAsAsync<CompanyOfficers>(response);

            return result;
        }

        private void ProceedUnsuccesfulResponse(HttpResponseMessage response, string targetObjectName)
        {
            var statusCode = (int)response.StatusCode;

            var errorMessage = $"response status code {statusCode}";

            if (statusCode >= 500)
            {
                _logger.LogError($"Failed to get {targetObjectName}");
                throw new CompaniesHouseApiServerException($"Failed to get {targetObjectName}: {errorMessage}");
            }

            if (statusCode == 404)
            {
                _logger.LogError($"Failed to get {targetObjectName}. Company not found");
                throw new NotFoundException($"Failed to get {targetObjectName}. Company not found");
            }

            if (statusCode >= 400)
            {
                _logger.LogError($"Failed to get {targetObjectName}");
                throw new BadRequestException($"Failed to get {targetObjectName}: {errorMessage}");
            }
        }

        private async Task<T> ReadResponseAsAsync<T>(HttpResponseMessage response)
        {
            var stringResult = await ReadResponseAsStringAsync(response);
            return JsonConvert.DeserializeObject<T>(stringResult);
        }

        private async Task<string> ReadResponseAsStringAsync(HttpResponseMessage response)
        {
            return await response.Content.ReadAsStringAsync();
        }
    }
}
