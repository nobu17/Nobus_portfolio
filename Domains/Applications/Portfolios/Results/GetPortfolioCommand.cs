using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Applications.Portfolios.Results
{
    public class GetPortfolioCommand
    {
        public GetPortfolioCommand(string id)
        {
            Id = id;
        }
        public string Id { get; }
    }
}
