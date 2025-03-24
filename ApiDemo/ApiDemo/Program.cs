using ApiDemo;
using DemoApi.Core.Repositories;
using DemoApi.Core.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

// Add configuration files
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
configurationBuilder.AddJsonFile("appsettings.json");
configurationBuilder.AddJsonFile($"appsettings.{environment}.json", true);
configurationBuilder.AddEnvironmentVariables();
var config = configurationBuilder.Build();

// Map Application setting
var appSetting = new ApplicationSetting();
var appSettingSection = config.GetSection("ApplicationSetting");
appSettingSection.Bind(appSetting);
builder.Services.AddSingleton(Options.Create(appSetting));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
