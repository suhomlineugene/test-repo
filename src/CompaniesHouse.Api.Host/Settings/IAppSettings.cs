namespace CompaniesHouse.Api.Host.Settings
{
    public interface IAppSettings
    {
        string DbConnectionString { get; }

        LogLevel LogLevel { get; }

        string CompanyHouseBaseUrl { get; }

        string CompanyHouseApiKey { get; }

        string HttpClientTimeout { get; }

        string IsSwaggerEnable { get; }
    }
}
