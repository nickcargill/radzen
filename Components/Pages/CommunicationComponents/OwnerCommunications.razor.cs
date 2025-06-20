using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class OwnerCommunications
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

        protected IEnumerable<Destination.Models.destinationTest.OwnerCommunication> ownerCommunications;

        protected RadzenDataGrid<Destination.Models.destinationTest.OwnerCommunication> grid0;
        protected override async Task OnInitializedAsync()
        {
            ownerCommunications = await destinationTestService.GetOwnerCommunications(new Query { Expand = "Agent1" });
        }
    }
}