namespace CompaniesHouse.Api.Host.Settings
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings()
        {
            var environment = Environment.GetEnvironmentVariable("ENVIRONMENT");

            _configuration = new ConfigurationBuilder()
                .AddSystemsManager($"/monspire/{environment}/INFRASTRUCTURE")
                .AddSystemsManager($"/monspire/{environment}/THIRD_PARTY")
                .AddSystemsManager($"/monspire/{environment}/COMPANIES_HOUSE_API")
                .AddEnvironmentVariables()
                .Build();
        }

        //INFRASTRUCTURE
        public string DbConnectionString => _configuration["COMPANYHOUSE_DB_CONNECTION"];

        //THIRD_PARTY
        public string CompanyHouseBaseUrl => _configuration["COMPANIES_HOUSE_BASE_URL"];

        public string CompanyHouseApiKey => _configuration["COMPANIES_HOUSE_API_KEY"];

        //COMPANIES_HOUSE_API
        public LogLevel LogLevel => Enum.Parse<LogLevel>(_configuration["LOG_LEVEL"]);

        public string HttpClientTimeout => _configuration["HTTP_CLIENT_TIMEOUT"];

        public string IsSwaggerEnable => _configuration["IS_SWAGGER_ENABLE"];
    }
}
