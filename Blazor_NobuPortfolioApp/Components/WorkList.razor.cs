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
        private WorkDisplayDialog workDisplayDialog;

        [Parameter]
        public List<WorkItem> WorkItems { get; set; }

        public async void ShowDetailDialog(WorkItem item)
        {
            await workDisplayDialog.ShowDialog(item);
        }
    }
}
