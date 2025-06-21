using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;
using Destination.Models.destinationTest;
using DocumentFormat.OpenXml.Bibliography;
using static Destination.Shared.DTO.AllDropDownValues;
using Destination.Shared.DTO;

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

        private bool menuVisible = false;
        private string activeForm = "booking";

        [Parameter]
        public int Id { get; set; } = 0;

        [Parameter]
        [SupplyParameterFromQuery]
        public string? status { get; set; }

        public int PropParameterId = 0;

        protected RadzenDataGrid<Destination.Models.destinationTest.Booking> grid0;

        protected bool showPanels = false;
        protected bool isBottomPanel = false;
        protected int selectedBookingId = 0;
        protected int selectedPropertyId = 0;


        private bool isCollapsed = false;

        private bool showCollapse = true;

        private IEnumerable<Booking> pagedBookings;
        private int totalCount;

        protected bool isBookingHistoryTab = false;
        protected bool isCommTab = false;
        protected bool isVisitHistoryTab = false;
        protected bool isCreditRequest = false;


        private string menuStyle => menuVisible ?
            "position: absolute; top: 40px; left: 5px; background: white; z-index: 10; box-shadow: 0 2px 10px rgba(0,0,0,0.1); border-radius: 4px; border: 1px solid #e0e0e0;" :
            "display: none;";
        private void ToggleMenu()
        {
            menuVisible = !menuVisible;
            StateHasChanged();
        }
        private void LoadForm(string formName)
        {
            activeForm = formName;
            menuVisible = false;
            StateHasChanged();
        }

        private void ShowCollapse()
        {
            showCollapse = true;
            showPanels = true;
        }
        private void OnTabChange(int index)
        {
            switch (index)
            {
                case 1:
                    isBookingHistoryTab = true;
                    break;
                case 2:
                    isCommTab = true;
                    break;
                case 3:
                    isVisitHistoryTab = true;
                    break;
                case 4:
                    isCreditRequest = true;
                    break;
            }
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
            if (Id != 0)
            {
                PropParameterId = Id;
                var query = new Query
                {
                    OrderBy = "Id",
                    Skip = 0,
                    Top = 20
                };
                var result = await bookingService.GetBookingsByPropId(query, Id);
                pagedBookings = result.Items;
                totalCount = result.Count;
            }
        }

        private async Task LoadData(LoadDataArgs args)
        {
            var query = new Query
            {
                Filter = args.Filter,
                OrderBy = string.IsNullOrEmpty(args.OrderBy) ? "Id desc" : args.OrderBy,
                Skip = args.Skip,
                Top = args.Top
            };

            var result = Id != 0
                ? await bookingService.GetBookingsByPropId(query, Id)
                : await bookingService.GetBookingsPagedAsync(query, status);

            pagedBookings = result.Items;
            totalCount = result.Count;
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
            isBottomPanel = false;
            sharedEvents.NotifyBookingIdClicked(bookingId);
            await Task.Delay(1);
            showPanels = true;
            showCollapse = true;
            isBottomPanel = true;
            selectedPropertyId = 0;
            StateHasChanged();
        }

        protected async Task ShowPropertyTabs(int? propId, int bookingId)
        {
            selectedPropertyId = 0;
            await Task.Delay(1);
            selectedPropertyId = propId.Value;
            selectedBookingId=bookingId;
            isBottomPanel = false;
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

        private BookingFilterModel filterModel = new();
        private List<PropertyDropDownData> filterProperties = new();
        private List<BookingStatusDropDownData> statusList = new();
        private List<string> rrOptions = new() { "All", "Yes", "No" };
        private List<string> coOptions = new() { "All", "Yes", "No" };
        private List<string> cleaningOptions = new() { "All", "Cleaned", "Not Cleaned" };
        private List<string> backToBackOptions = new() { "All", "Yes", "No" };
        private List<PropertySource> sources = new();
        private List<string> cities = new()
        {
            "Big Bear","Big Bear City","Big Bear Lake","Frawnskin"
        };

        private bool isFirstRender = true;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && isFirstRender)
            {
                isFirstRender = false;

                // Load dropdowns after render
                await LoadDropdownsAsync();

                StateHasChanged(); // Update UI after loading
            }
        }

        protected async Task LoadDropdownsAsync()
        {
            filterProperties = await destinationTestService.GetPropertiesForDropDown();
            statusList = await destinationTestService.GetBookingStatusesForDropDown();
            sources = await destinationTestService.GetPropertySources();
        }

        private async Task OnSearch()
        {
            var query = new Query
            {
                OrderBy = "Id",
                Skip = 0,
                Top = 20
            };
            var result = await bookingService.GetBookingsPagedAsync(query, status, filterModel);
            pagedBookings = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        private void OnReset()
        {
            filterModel = new BookingFilterModel(); // reset all values
        }
    }
}