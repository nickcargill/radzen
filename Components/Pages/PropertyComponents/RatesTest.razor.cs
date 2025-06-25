using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Radzen;
using Microsoft.AspNetCore.Components.Web;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Destination.Services;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class RatesTest
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
        public destinationTestService destinationTestService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        public PropertyService propertyService { get; set; }

        string propName = string.Empty;


        PropertyRate propertyRate = new PropertyRate();
        PropertyRatesVrbo vrboRates = new PropertyRatesVrbo();

        protected RadzenDataGrid<Booking> grid0;
        protected Booking booking;

        [Parameter]
        public int Id { get; set; }

        protected bool isVrboRateEdit = true;
        protected bool isPropertyRateEdit = true;
        Destination.Models.destinationTest.Property property = new ();


        protected override async Task OnInitializedAsync()
        {
            propertyRate = await destinationTestService.GetPropertyRateById(Id);
            vrboRates = await destinationTestService.GetPropertyRateVRBOById(Id);
            property = await destinationTestService.GetPropertyByPropid(Id);


            if (property != null && !string.IsNullOrEmpty(property.Name))
            {
                propName = property.Name + " - " + "Property Rates";
            }
            else
            {
                propName = "Property Rates";
            }

            if (propertyRate == null)
            {
                propertyRate = new PropertyRate();
                propertyRate.Propid = Id;
                isPropertyRateEdit = false;
            }
            if (vrboRates == null)
            {
                vrboRates = new PropertyRatesVrbo();
                vrboRates.Propid = Id;
                isVrboRateEdit = false;
            }

            StateHasChanged();
        }

        protected async Task Submit(PropertyRate arg)
        {
            var result = await propertyService.UpdaterPopertyRates(arg, isPropertyRateEdit);
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

        protected async Task SubmitVRBO(PropertyRatesVrbo arg)
        {
            var result = await propertyService.UpdateVrboRates(arg, isVrboRateEdit);
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