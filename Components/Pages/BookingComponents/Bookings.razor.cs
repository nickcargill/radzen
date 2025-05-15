using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class Bookings
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

        protected IEnumerable<Destination.Models.destinationTest.Booking> bookings;

        [Inject]
        public SharedEvents sharedEvents { get; set; }

        [Parameter]
        public int Id { get; set; } = 0;

        public int PropParameterId = 0;

        protected RadzenDataGrid<Destination.Models.destinationTest.Booking> grid0;

        protected bool showPanels = false;
        protected int selectedBookingId = 0;

        private bool isCollapsed = false;

        private bool showCollapse = true;

        private void ShowCollapse()
        {
            showCollapse = true;
            showPanels = true;
        }

        void PickedColumnsChanged(DataGridPickedColumnsChangedEventArgs<Destination.Models.destinationTest.Booking> args)
        {
        }
        private void HidePanel()
        {
            showCollapse = false;
            showPanels = false;
        }

        protected override async Task OnInitializedAsync()
        {
            PropParameterId = Id;
            bookings = await destinationTestService.GetBookings(new Query { Expand = "Property,BookingStatus,Tenant,PropertySource,TblService" });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddBooking>("Add Booking", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Booking args)
        {
          //  await DialogService.OpenAsync<EditBooking>("Edit Booking", new Dictionary<string, object> { {"Id", args.Id} });
        }

        protected async Task ShowPanels(int bookingId)
        {
            showPanels = false;
            selectedBookingId = bookingId;
            sharedEvents.NotifyBookingIdClicked(bookingId);
            await Task.Delay(1);
            showPanels = true;
            StateHasChanged();
        }

        void Change(string text)
        {
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Booking booking)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteBooking(booking.Id);

                    if (deleteResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = $"Error",
                    Detail = $"Unable to delete Booking"
                });
            }
        }
    }
}