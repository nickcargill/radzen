using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Radzen;
using Microsoft.AspNetCore.Components.Web;
using Radzen.Blazor;

namespace Destination.Components.Pages
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
        
        protected Destination.Models.destinationTest.PropertyRate propertyRate;

        protected IEnumerable<Destination.Models.destinationTest.Booking> bookings;

        protected RadzenDataGrid<Destination.Models.destinationTest.Booking> grid0;
        protected Destination.Models.destinationTest.Booking booking;
        
        // [Parameter]
        // public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            propertyRate = await destinationTestService.GetPropertyRateById(30);
            bookings = await destinationTestService.GetBookings();
        }
    }
}