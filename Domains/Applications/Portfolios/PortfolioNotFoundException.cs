using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Applications.Portfolios
{
    public class PortfolioNotFoundException : Exception
    {
        public PortfolioNotFoundException(string id, string message) : base(message)
        {
            Id = id;
        }

        public string Id { get; }
        public string Name { get; }
    }
}
