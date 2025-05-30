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

        protected PropertyRate propertyRate;
        protected PropertyRatesVrbo vrboRates;

        protected IEnumerable<Booking> bookings;

        protected RadzenDataGrid<Booking> grid0;
        protected Booking booking;

        [Parameter]
        public int Id { get; set; }

        protected bool isVrboRateEdit = true;
        protected bool isPropertyRateEdit = true;

        protected override async Task OnInitializedAsync()
        {
            propertyRate = await destinationTestService.GetPropertyRateById(Id);
            vrboRates = await destinationTestService.GetPropertyRateVRBOById(Id);

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
           // bookings = await destinationTestService.GetBookings();
        }

        protected async Task Submit(PropertyRate arg)
        {
            var result = await propertyService.UpdaterPopertyRates(arg, isPropertyRateEdit);
            if (result)
            {
                StateHasChanged();
                NavigationManager.NavigateTo("/properties");
            }
        }

        protected async Task SubmitVRBO(PropertyRatesVrbo arg)
        {
            var result = await propertyService.UpdateVrboRates(arg, isVrboRateEdit);
            if (result)
            {
                StateHasChanged();
                NavigationManager.NavigateTo("/properties");
            }
        }
    }
}