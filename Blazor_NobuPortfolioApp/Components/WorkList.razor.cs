using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class WorkList
    {
        private WorkDisplayDialog workDisplayDialog;

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public List<WorkItem> WorkItems { get; set; }

        public async void ShowDetailDialog(WorkItem item)
        {
            await workDisplayDialog?.ShowDialog(item);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("startFadeupAnimation", ".work-card");
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
