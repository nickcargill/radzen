using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;
using Destination.Models.destinationTest;

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

        [Inject]
        public BookingService bookingService { get; set; }

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

        private IEnumerable<Booking> pagedBookings;
        private int totalCount;
        private bool dataLoaded = false;

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
            if(Id != 0)
            {
                PropParameterId = Id;


                var query = new Query
                {
                    OrderBy = "Id",
                    Skip = 0,
                    Top = 15
                };

                var result = await bookingService.GetBookingsByPropId(query,Id);
                pagedBookings = result.Items;
                totalCount = result.Count;
            }
            else
            {
                var a = bookingService.GetPaymentsByBookingId(23953);
                var initialArgs = new LoadDataArgs
                {
                    Skip = 0,
                    Top = 15,
                    OrderBy = "Id" // Or null, depending on your needs
                };

                await LoadData(initialArgs);
            }
        }
        private async Task LoadData(LoadDataArgs args)
        {
            if (!dataLoaded || args.Skip != 0) // Load only once unless paging happens
            {
                dataLoaded = true;

                var query = new Query
                {
                    Filter = args.Filter,
                    OrderBy = "Id",
                    Skip = args.Skip,
                    Top = args.Top
                };

                var result = await bookingService.GetBookingsPagedAsync(query);
                pagedBookings = result.Items;
                totalCount = result.Count;
                StateHasChanged();
            }
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
            showCollapse = true;
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