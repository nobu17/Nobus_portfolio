using Domains.Models.Portofolios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Services
{
    public class PortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;

        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            this._portfolioRepository = portfolioRepository;
        }

        public bool Exists(Portfolio portfolio)
        {
            var target = _portfolioRepository.Find(portfolio.Id);
            return target != null;
        }
    }
}
