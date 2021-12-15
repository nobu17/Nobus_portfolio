using Blazor_NobuPortfolioApp;
using Domains.Applications.Portfolios;
using Domains.Models.Portofolios;
using Domains.Services;
using InMemoryInfrastructure;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IPortfolioRepository, InMemoryPortfolioRepository>();
builder.Services.AddSingleton<PortfolioApplicationService>();
builder.Services.AddSingleton<PortfolioService>();

await builder.Build().RunAsync();

