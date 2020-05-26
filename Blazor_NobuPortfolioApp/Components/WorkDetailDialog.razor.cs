using Blazored.Modal;
using Domains.Models.Portofolios;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_NobuPortfolioApp.Components
{
    public partial class WorkDetailDialog
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        [Parameter] public WorkItem WorkItem { get; set; }

        protected override void OnInitialized()
        {
        }
    }
}
