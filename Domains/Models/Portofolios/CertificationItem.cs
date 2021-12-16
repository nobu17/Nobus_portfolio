using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Models.Portofolios
{
    public class CertificationItem
    {
        public CertificationItem(string id, string name, string acquisitionDate, string iconUrl)
        {
            Id = id;
            Name = name;
            AcquisitionDate = acquisitionDate;
            IconUrl = iconUrl;
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string AcquisitionDate { get; private set; }

        public string IconUrl { get; private set; }
    }
}
