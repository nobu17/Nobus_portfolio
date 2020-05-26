using Domains.Models.Portofolios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Applications.Portfolios.Results
{
    public class GetPortfolioResult
    {
        public GetPortfolioResult(Portfolio portfolio)
        {
            Portfolio = portfolio;
        }
        public Portfolio Portfolio { get; }
    }
}
