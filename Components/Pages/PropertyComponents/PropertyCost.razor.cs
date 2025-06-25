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
using static Destination.Shared.DTO.AllDropDownValues;

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

        Property property = new Property();

        protected IEnumerable<PropertyCleanerDDValues> propertyCleaners;
        protected IEnumerable<OwnerLoginDDValues> ownerLogins;

        string propName = string.Empty;



        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);

            if (property != null && !string.IsNullOrEmpty(property.Name))
            {
                propName = property.Name + " - " + "Property Cost";
            }
            else
            {
                propName = "Property Cost";
            }

            propertyCleaners = await propertyService.GetPropertyCleanerDropDownValues();
            ownerLogins = await propertyService.GetOwnerDropDownValues();
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