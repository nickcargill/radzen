using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class AddProperty
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

        protected override async Task OnInitializedAsync()
        {
            property = new Destination.Models.destinationTest.Property();

            agentsForAgentid = await destinationTestService.GetAgents();

            statusesForStatus = await destinationTestService.GetStatuses();

            propertyCleanersForCleanerassigned = await destinationTestService.GetPropertyCleaners();
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Property property;

        protected IEnumerable<Destination.Models.destinationTest.Agent> agentsForAgentid;

        protected IEnumerable<Destination.Models.destinationTest.Status> statusesForStatus;

        protected IEnumerable<Destination.Models.destinationTest.PropertyCleaner> propertyCleanersForCleanerassigned;

        protected async Task FormSubmit()
        {
            try
            {
                await destinationTestService.CreateProperty(property);
                DialogService.Close(property);
            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}