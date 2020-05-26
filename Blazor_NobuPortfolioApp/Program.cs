using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazored.Modal;
using Domains.Models.Portofolios;
using InMemoryInfrastructure;
using Domains.Applications.Portfolios;
using Domains.Services;

namespace Blazor_NobuPortfolioApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredModal();

            builder.Services.AddSingleton<IPortfolioRepository, InMemoryPortfolioRepository>();
            builder.Services.AddSingleton<PortfolioApplicationService>();
            builder.Services.AddSingleton<PortfolioService>();
            
            await builder.Build().RunAsync();
        }
    }
}
