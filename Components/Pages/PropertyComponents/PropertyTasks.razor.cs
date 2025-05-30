using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyTasks
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Inject]
        public PropertyService propertyService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected IEnumerable<Destination.Models.destinationTest.VwMaintenanceNextDateFrom> vwMaintenanceNextDateFroms;

        protected RadzenDataGrid<Destination.Models.destinationTest.VwMaintenanceNextDateFrom> grid0;
        protected override async Task OnInitializedAsync()
        {
            vwMaintenanceNextDateFroms  = await propertyService.GetTasksByPropId(Id);
        }
    }
}