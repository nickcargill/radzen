using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class EditBooking
    {

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

        protected override async Task OnInitializedAsync()
        {
            booking = await destinationTestService.GetBookingById(Id);
            bookingStatusesForStatusid = await destinationTestService.GetBookingStatusesForDropDown();
            tenantsForTenantid = await destinationTestService.GetTenantsForDropDown();
            propertiesForPropertyid = await destinationTestService.GetPropertiesForDropDown();
        }


        protected bool errorVisible;
        protected Destination.Models.destinationTest.Booking booking;

        protected IEnumerable<PropertyDropDownData> propertiesForPropertyid;

        protected IEnumerable<BookingStatusDropDownData> bookingStatusesForStatusid;

        protected IEnumerable<TenantDropDownData> tenantsForTenantid;

        protected IEnumerable<Destination.Models.destinationTest.PropertySource> propertySourcesForSourceid;

        protected IEnumerable<Destination.Models.destinationTest.TblService> tblServicesForServiceId;

        protected async Task FormSubmit()
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

        protected async Task CancelButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}