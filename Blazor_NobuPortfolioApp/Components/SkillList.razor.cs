using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class SkillList
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public List<SkillItem> SkillItems { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("startBarAnimation");
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
