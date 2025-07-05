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
using Microsoft.AspNetCore.WebUtilities;

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
        public EventCallback<int> OnBookingIdClicked { get; set; }

        public int PropParameterId = 0;

        protected RadzenDataGrid<Destination.Models.destinationTest.Booking> grid0;

        Property property = new Property();

        string propName = string.Empty;

        protected bool showPanels = false;
        protected bool isBottomPanel = false;
        protected int selectedBookingId = 0;
        protected int selectedPropertyId = 0;
        protected int? selectedTenantId = 0;


        private bool isCollapsed = false;

        private bool showCollapse = true;

        private IEnumerable<Booking> pagedBookings;
        private int totalCount;

        protected bool isBookingHistoryTab = false;
        protected bool isCommTab = false;
        protected bool isVisitHistoryTab = false;
        protected bool isCreditRequest = false;
        protected bool isTenantHistoryTab = false;



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
                case 5:
                    isTenantHistoryTab = true;
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

        //private QueryParamFilterModel queryParamFilters = new();

        protected override async Task OnInitializedAsync()
        {
            sharedEvents.OnIdClickedFromTenantHist += HandleBookingEdit;

            if (Id != 0)
            {
                property = await destinationTestService.GetPropertyByPropid(Id);

                if (property != null && !string.IsNullOrEmpty(property.Name))
                {
                    propName = property.Name + " - " + "Bookings";
                }
                else
                {
                    propName = "Bookings";
                }

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
                : await bookingService.GetBookingsPagedAsync(query, null, filterModel);

            pagedBookings = result.Items;
            totalCount = result.Count;
            StateHasChanged();
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

        private void HandleBookingEdit(int Id)
        {
            selectedBookingId = Id;
            PropParameterId = 0;
            showPanels = true;
            showCollapse = true;
            StateHasChanged();
        }
        protected async Task ShowPanels(int bookingId)
        {
            if (PropParameterId != 0)
            {
                await OnBookingIdClicked.InvokeAsync(bookingId);
                sharedEvents.NotifyBookingIdClicked(bookingId);
                return;
            }
            showPanels = false;
            selectedBookingId = bookingId;
            await Task.Delay(1);
            showPanels = true;
            showCollapse = true;
            isBottomPanel = false;
            StateHasChanged();
        }

        protected async Task ShowleftPanel(int bookingId, int? tenantId)
        {
            PropParameterId = 0;
            selectedPropertyId = 0;
            showPanels = false;
            selectedBookingId = bookingId;
            selectedTenantId = tenantId;
            isBottomPanel = false;
            await Task.Delay(1);
            showPanels = true;
            showCollapse = true;
            isBottomPanel = true;
            StateHasChanged();
        }

        protected async Task ShowPropertyTabs(int? propId, int bookingId)
        {
            showPanels = false;
            selectedPropertyId = 0;
            await Task.Delay(1);
            selectedPropertyId = propId.Value;
            selectedBookingId = bookingId;
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
        private List<string> cleaningOptions = new() { "All", "Cleaned", "Not Cleaned" };
        private List<PropertySource> sources = new ();
        private List<string> cities = new()
        {
            "Big Bear", "Big Bear City", "Big Bear Lake", "Frawnskin"
        };
        private bool isFirstRender = true;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && isFirstRender)
            {
                isFirstRender = false;
                await LoadDropdownsAsync();
                await ParseQueryParametersAsync();
                StateHasChanged();
            }
        }

        protected async Task LoadDropdownsAsync()
        {
            filterProperties = await destinationTestService.GetPropertiesForDropDown();
            statusList = await destinationTestService.GetBookingStatusesForDropDown();
            sources = await destinationTestService.GetPropertySources();
        }

        private async Task ParseQueryParametersAsync()
        {
            var uri = new Uri(NavigationManager.Uri);
            var queryParams = QueryHelpers.ParseQuery(uri.Query);

            if (queryParams.TryGetValue("id", out var idValue) && int.TryParse(idValue.FirstOrDefault(), out var id))
            {
                filterModel.FilterModelId = id;
            }
            if (queryParams.TryGetValue("dateFrom1", out var dateFrom1) && DateTime.TryParse(dateFrom1.FirstOrDefault(), out var dateFrom1Value))
            {
                filterModel.DateFrom1 = dateFrom1Value;
            }
            if (queryParams.TryGetValue("dateFrom2", out var dateFrom2) && DateTime.TryParse(dateFrom2.FirstOrDefault(), out var dateFrom2Value))
            {
                filterModel.DateFrom2 = dateFrom2Value;
            }
            if (queryParams.TryGetValue("dateTo1", out var dateTo1) && DateTime.TryParse(dateTo1.FirstOrDefault(), out var dateTo1Value))
            {
                filterModel.DateTo1 = dateTo1Value;
            }
            if (queryParams.TryGetValue("dateTo2", out var dateTo2) && DateTime.TryParse(dateTo2.FirstOrDefault(), out var dateTo2Value))
            {
                filterModel.DateTo2 = dateTo2Value;
            }
            if (queryParams.TryGetValue("bookedFrom1", out var bookedFrom1) && DateTime.TryParse(bookedFrom1.FirstOrDefault(), out var bookedFrom1Value))
            {
                filterModel.BookedFrom1 = bookedFrom1Value;
            }
            if (queryParams.TryGetValue("bookedFrom2", out var bookedFrom2) && DateTime.TryParse(bookedFrom2.FirstOrDefault(), out var bookedFrom2Value))
            {
                filterModel.BookedFrom2 = bookedFrom2Value;
            }
            if (queryParams.TryGetValue("propertyName", out var propertyName))
            {
                var name = propertyName.FirstOrDefault();
                var property = filterProperties.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
                filterModel.PropertyId = property?.Propid;
            }
            if (queryParams.TryGetValue("firstName", out var firstName))
            {
                filterModel.FirstName = firstName.FirstOrDefault();
            }
            if (queryParams.TryGetValue("lastName", out var lastName))
            {
                filterModel.LastName = lastName.FirstOrDefault();
            }
            if (queryParams.TryGetValue("status", out var status))
            {
                var statusText = status.FirstOrDefault();
                var statusItem = statusList.FirstOrDefault(s => s.Status.ToLower() == statusText.ToLower());
                filterModel.Status = statusItem?.Id;
            }
            if (queryParams.TryGetValue("phone", out var phone))
            {
                filterModel.Phone = phone.FirstOrDefault();
            }
            if (queryParams.TryGetValue("cleaning", out var cleaning))
            {
                var cleaningValue = cleaning.FirstOrDefault();
                if (cleaningOptions.Contains(cleaningValue))
                {
                    filterModel.Cleaning = cleaningValue;
                }
            }
            if (queryParams.TryGetValue("sleeps1", out var sleeps1) && int.TryParse(sleeps1.FirstOrDefault(), out var sleeps1Value))
            {
                filterModel.Sleeps1 = sleeps1Value;
            }
            if (queryParams.TryGetValue("sleeps2", out var sleeps2) && int.TryParse(sleeps2.FirstOrDefault(), out var sleeps2Value))
            {
                filterModel.Sleeps2 = sleeps2Value;
            }
            if (queryParams.TryGetValue("source", out var source))
            {
                var sourceText = source.FirstOrDefault();
                var sourceItem = sources.FirstOrDefault(s => s.Source == sourceText);
                filterModel.Source = sourceItem?.Id ?? 0;
            }
            if (queryParams.TryGetValue("email", out var email))
            {
                filterModel.Email = email.FirstOrDefault();
            }
            if (queryParams.TryGetValue("city", out var city))
            {
                var cityValue = city.FirstOrDefault();
                if (cities.Contains(cityValue))
                {
                    filterModel.City = cityValue;
                }
            }

            // Trigger search if query parameters exist
            if (queryParams.Count > 0)
            {
                await OnSearch();
            }
        }

        private async Task UpdateQueryParameters()
        {
            var queryParams = new Dictionary<string, string>();

            if (filterModel.FilterModelId != 0)
                queryParams.Add("id", filterModel.FilterModelId.ToString());
            if (filterModel.DateFrom1.HasValue)
                queryParams.Add("dateFrom1", filterModel.DateFrom1.Value.ToString("yyyy-MM-dd"));
            if (filterModel.DateFrom2.HasValue)
                queryParams.Add("dateFrom2", filterModel.DateFrom2.Value.ToString("yyyy-MM-dd"));
            if (filterModel.DateTo1.HasValue)
                queryParams.Add("dateTo1", filterModel.DateTo1.Value.ToString("yyyy-MM-dd"));
            if (filterModel.DateTo2.HasValue)
                queryParams.Add("dateTo2", filterModel.DateTo2.Value.ToString("yyyy-MM-dd"));
            if (filterModel.BookedFrom1.HasValue)
                queryParams.Add("bookedFrom1", filterModel.BookedFrom1.Value.ToString("yyyy-MM-dd"));
            if (filterModel.BookedFrom2.HasValue)
                queryParams.Add("bookedFrom2", filterModel.BookedFrom2.Value.ToString("yyyy-MM-dd"));
            if (filterModel.PropertyId.HasValue)
            {
                var property = filterProperties.FirstOrDefault(p => p.Propid == filterModel.PropertyId);
                if (property != null)
                    queryParams.Add("propertyName", property.Name);
            }
            if (!string.IsNullOrWhiteSpace(filterModel.FirstName))
                queryParams.Add("firstName", filterModel.FirstName);
            if (!string.IsNullOrWhiteSpace(filterModel.LastName))
                queryParams.Add("lastName", filterModel.LastName);
            if (filterModel.Status.HasValue)
            {
                var status = statusList.FirstOrDefault(s => s.Id == filterModel.Status);
                if (status != null)
                    queryParams.Add("status", status.Status);
            }
            if (!string.IsNullOrWhiteSpace(filterModel.Phone))
                queryParams.Add("phone", filterModel.Phone);
            if (!string.IsNullOrWhiteSpace(filterModel.Cleaning))
                queryParams.Add("cleaning", filterModel.Cleaning);
            if (filterModel.Sleeps1 != 0)
                queryParams.Add("sleeps1", filterModel.Sleeps1.ToString());
            if (filterModel.Sleeps2 != 0)
                queryParams.Add("sleeps2", filterModel.Sleeps2.ToString());
            if (filterModel.Source != 0)
            {
                var source = sources.FirstOrDefault(s => s.Id == filterModel.Source);
                if (source != null)
                    queryParams.Add("source", source.Source);
            }
            if (!string.IsNullOrWhiteSpace(filterModel.Email))
                queryParams.Add("email", filterModel.Email);
            if (!string.IsNullOrWhiteSpace(filterModel.City))
                queryParams.Add("city", filterModel.City);

            var uri = NavigationManager.Uri;
            var baseUri = uri.Contains("?") ? uri.Substring(0, uri.IndexOf("?")) : uri;
            var newQueryString = QueryString.Create(queryParams);
            NavigationManager.NavigateTo($"{baseUri}{newQueryString}", forceLoad: false);
        }

        private async Task OnSearch()
        {
            await UpdateQueryParameters(); // Update URL before searching
            var query = new Query
            {
                OrderBy = "Id",
                Skip = 0,
                Top = 20
            };
            var result = await bookingService.GetBookingsPagedAsync(query, null, filterModel);
            pagedBookings = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        private async Task OnReset()
        {
            filterModel = new BookingFilterModel(); // Reset all values
            await UpdateQueryParameters(); // Clear query parameters
            StateHasChanged();
        }
    }
}