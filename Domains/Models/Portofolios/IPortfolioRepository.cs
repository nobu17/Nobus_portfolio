using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Domains.Models.Portofolios
{
    public interface IPortfolioRepository
    {
        Portfolio Find(string id);
    }
}
