using Domains.Applications.Portfolios.Results;
using Domains.Models.Portofolios;
using Domains.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Applications.Portfolios
{
    public class PortfolioApplicationService
    {
        private readonly IPortfolioRepository _portfolioRepository;
        private readonly PortfolioService _portfolioService;

        public PortfolioApplicationService(IPortfolioRepository portfolioRepository, PortfolioService portfolioService)
        {
            this._portfolioRepository = portfolioRepository;
            this._portfolioService = portfolioService;
        }

        public GetPortfolioResult Get(GetPortfolioCommand command)
        {
            var portfolio = _portfolioRepository.Find(command.Id);
            if (portfolio == null)
            {
                throw new PortfolioNotFoundException(command.Id, "データが見つかりませんでした。");
            }

            return new GetPortfolioResult(portfolio);
        }
    }
}
