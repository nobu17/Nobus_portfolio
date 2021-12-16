using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class CertificationList
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public List<CertificationItem> CertificationItems { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("startFadeupAnimation", ".cert-card");
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
