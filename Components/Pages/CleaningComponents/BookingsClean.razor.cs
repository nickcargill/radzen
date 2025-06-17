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

namespace Destination.Components.Pages.CleaningComponents
{
    public partial class BookingsClean
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

        [Parameter] 
        public int Id { get; set; }

        private Booking booking = new();
        private List<PropertyCleaner> cleaners = new();

        protected override async Task OnInitializedAsync()
        {
            booking = await bookingService.GetBookingsCleanerById(Id);
            cleaners = await bookingService.GetBookingsCleanersAsync();
        }

        private async Task HandleSubmit()
        {
          //  await BookingService.UpdateBookingAsync(booking);
            // Optionally navigate away or show a message
        }
    }
}