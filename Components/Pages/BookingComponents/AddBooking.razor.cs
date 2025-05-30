using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class AddBooking
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
            booking = new Destination.Models.destinationTest.Booking();

            propertiesForPropertyid = await destinationTestService.GetProperties();

            bookingStatusesForStatusid = await destinationTestService.GetBookingStatuses();

            tenantsForTenantid = await destinationTestService.GetTenants();

            propertySourcesForSourceid = await destinationTestService.GetPropertySources();

            tblServicesForServiceId = await destinationTestService.GetTblServices();
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Booking booking;

        protected IEnumerable<Destination.Models.destinationTest.Property> propertiesForPropertyid;

        protected IEnumerable<Destination.Models.destinationTest.BookingStatus> bookingStatusesForStatusid;

        protected IEnumerable<Destination.Models.destinationTest.Tenant> tenantsForTenantid;

        protected IEnumerable<Destination.Models.destinationTest.PropertySource> propertySourcesForSourceid;

        protected IEnumerable<Destination.Models.destinationTest.TblService> tblServicesForServiceId;

        protected async Task FormSubmit()
        {
            try
            {
                await destinationTestService.CreateBooking(booking);
                DialogService.Close(booking);
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