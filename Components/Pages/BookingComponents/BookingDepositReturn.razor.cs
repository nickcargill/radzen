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
using Destination.Services;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingDepositReturn
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
        protected BookingService bookingService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected Destination.Models.destinationTest.Booking booking;
        private List<PropertyCleaner> cleaners = new();

        protected override async Task OnInitializedAsync()
        {
            booking = await bookingService.GetBookingsCleanerById(Id);
            cleaners = await bookingService.GetBookingsCleanersAsync();
        }

        protected bool errorVisible;

        private async Task FormSubmit()
        {
            try
            {
                await destinationTestService.UpdateBooking(Id, booking);
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Data updated successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }
    }
}