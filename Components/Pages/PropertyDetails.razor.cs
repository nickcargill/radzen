using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;


namespace Destination.Components.Pages
{
    public partial class PropertyDetails
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

        [Parameter]
        public int Id { get; set; }

        protected Property property;


        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);
              agentsForAgentid = await destinationTestService.GetAgents();
              statusesForStatus = await destinationTestService.GetStatuses();
         //   propertyTypes = await destinationTestService.GetPropertyTypes();
        }


        protected IEnumerable<Agent> agentsForAgentid;

        protected IEnumerable<Status> statusesForStatus;

        protected IEnumerable<PropertyType> propertyTypes;

        private async Task UpdateProperty()
        {
            try
            {
                // Save logic here
                // await SaveProperty(propertyModel);
            }
            catch (Exception ex)
            {
            
        }
    }
}
}
