using Blazored.Modal;
using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class WorkList
    {

        [Parameter]
        public List<WorkItem> WorkItems { get; set; }

        public void ShowDetailDialog(WorkItem item)
        {
            var parameters = new ModalParameters();
            parameters.Add("WorkItem", item);
            Modal.Show<WorkDetailDialog>(item.Name, parameters);
            // Modal.Show<WorkDetailDialog>(item.Name + " ( " + item.SubTitle + " ) ", parameters);
        }
    }
}
