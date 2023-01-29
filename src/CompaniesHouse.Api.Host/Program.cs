using System.Net.Http.Headers;
using System.Text;
using CompaniesHouse.Api.Host.ApiClients;
using CompaniesHouse.Api.Host.Apis;
using CompaniesHouse.Api.Host.Data;
using CompaniesHouse.Api.Host.Middleware;
using CompaniesHouse.Api.Host.Services;
using CompaniesHouse.Api.Host.Settings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var settings = new AppSettings();

RegisterServices(builder.Services);

var app = builder.Build();

Configure(app);

var api = app.Services.GetService<CompanyApi>();

api.Register(app);

app.Run();

void RegisterServices(IServiceCollection services)
{
    services.AddEndpointsApiExplorer();

    services.AddSwaggerGen();

    services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

    services.AddSingleton<IAppSettings>(settings);

    services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(settings.DbConnectionString,
            ServerVersion.AutoDetect(settings.DbConnectionString))
    );

    services.AddLogging((logging =>
    {
        logging.AddLambdaLogger();
        logging.SetMinimumLevel(settings.LogLevel);
    }));

    services.AddHttpClient<ICompaniesHouseApiClient, CompaniesHouseApiClient>(options =>
    {
        options.BaseAddress = new Uri(settings.CompanyHouseBaseUrl);
        
        var encodedApiKey = Encoding.UTF8.GetBytes(settings.CompanyHouseApiKey);
        options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
            Convert.ToBase64String(encodedApiKey));

        options.Timeout = TimeSpan.FromSeconds(int.Parse(settings.HttpClientTimeout));
    });

    services.AddTransient<ICompanyService, CompanyService>();

    services.AddAutoMapper(typeof(ICompanyService));

    services.AddTransient<CompanyApi>();
}

void Configure(WebApplication app)
{
    if (settings.IsSwaggerEnable == bool.TrueString)
    {
        app.UseSwagger();
        app.UseSwaggerUI(config =>
        {
            config.RoutePrefix = string.Empty;
            config.SwaggerEndpoint("swagger/v1/swagger.json", "Companies House Api");
        });
    }

    app.UseMiddleware<ExceptionMiddleware>();

    app.UseHttpsRedirection();
}
