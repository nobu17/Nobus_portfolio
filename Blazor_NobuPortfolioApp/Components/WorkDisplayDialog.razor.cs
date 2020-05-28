using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class WorkDisplayDialog
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        private WorkItem WorkItem { get; set; }

        public async Task ShowDialog(WorkItem item)
        {
            WorkItem = item;
            await JSRuntime.InvokeVoidAsync("openWorkDisplayDialog");
            StateHasChanged();
        }
    }
}
