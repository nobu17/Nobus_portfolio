using Domains.Applications.Portfolios;
using Domains.Applications.Portfolios.Results;
using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Pages
{
    public partial class Index
    {
        [Inject]
        protected PortfolioApplicationService AppService { get; set; }
        public Portfolio Portfolio { get; set; }

        protected override void OnInitialized()
        {
            var result = AppService.Get(new GetPortfolioCommand("1"));
            Portfolio = result.Portfolio;
        }
    }
}
