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
using Destination.Models.destinationTest;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyCost
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

        private string errorMessage;

        [Inject]
        public PropertyService propertyService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected Property property;


        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);
            //  cleanerOptions = await GetCleanerOptions();
            // ownerLoginOptions = await GetOwnerLoginOptions();
        }

        private async Task UpdatePropertyCost()
        {
            try
            {
                // Save logic here
                errorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }
    }
}