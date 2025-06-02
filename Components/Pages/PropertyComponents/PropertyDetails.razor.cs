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
using static Destination.Shared.DTO.AllDropDownValues;
using Destination.Services;
using DocumentFormat.OpenXml.Drawing.Charts;


namespace Destination.Components.Pages.PropertyComponents
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

        [Inject]
        public PropertyService propertyService { get; set; }

        protected IEnumerable<AgentDropDownValues> agentsForAgentid;
        protected IEnumerable<AgentStatusDropDownValues> statusesForStatus;
        protected IEnumerable<PropertyTypeDropDownValues> propertyTypes;

        [Parameter]
        public int Id { get; set; }

        Property property = new Property();


        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);
            agentsForAgentid = await propertyService.GetAgentDropDownValues();
            statusesForStatus = await propertyService.GetAgentStatusDropDownValues();
            propertyTypes = await propertyService.GetPropertyTypesDropDownValues();
        }

        protected async Task Submit(Property arg)
        {
            var result = await propertyService.Updateproperty(arg);
            if (result)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Data updated successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
        }
    }
}
