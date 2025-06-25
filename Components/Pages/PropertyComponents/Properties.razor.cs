using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Components.Pages.BookingComponents;
using Destination.Services;
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class Properties
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
        public PropertyService propertyService { get; set; }

        [Inject]
        public SharedEvents sharedEvents { get; set; }

        protected IEnumerable<Property> properties;
        protected RadzenDataGrid<Property> grid0;
        protected bool showTabs = false;
        protected int selectedPropId = 0;
        protected int selectedBookingId = 0;

        protected bool isPropCostTab = false;
        protected bool isPropDescTab = false;
        protected bool isPropRatesTab = false;
        protected bool isPropHomeInfoTab = false;
        protected bool isPropBookingsTab = false;
        protected bool isPropTasksTab = false;
        protected bool isPropAnnualTab = false;
        protected bool isPropOwnerTab = false;
        protected bool isPropImprovementsTab = false;
        protected bool isPropHomeTeamTab = false;
        private bool menuVisible = false;
        private string activeForm = "EditBookings";

        protected bool showleftPanel = false;

        private IEnumerable<Property> pagedProperties;
        private int totalCount;
        private bool isCollapsed = false;

        private bool showCollapse = true;
        string propName = "";

        private void ShowCollapse()
        {
            showCollapse = true;
            showleftPanel = true;
        }

        private void HidePanel()
        {
            showCollapse = false;
            showleftPanel = false;
        }

        private async Task LoadData(LoadDataArgs args)
        {
            var query = new Query
            {
                Filter = args.Filter,
                OrderBy = string.IsNullOrEmpty(args.OrderBy) ? "PropId desc" : args.OrderBy,
                Skip = args.Skip,
                Top = args.Top
            };

            var result = await propertyService.GetPropertiesPagedAsync(query);
            pagedProperties = result.Items;
            totalCount = result.Count;
        }

        void PickedColumnsChanged(DataGridPickedColumnsChangedEventArgs<Destination.Models.destinationTest.Property> args)
        {
        }

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

        private void OnTabChange(int index)
        {
            switch (index)
            {
                case 1:
                    isPropDescTab = true;
                    break;
                case 2:
                    isPropHomeInfoTab = true;
                    break;
                case 3:
                    isPropCostTab = true;
                    break;
                case 4:
                    isPropRatesTab = true;
                    break;
                case 5:
                    isPropBookingsTab = true;
                    break;
                case 6:
                    isPropTasksTab = true;
                    break;
                case 7:
                    isPropAnnualTab = true;
                    break;
                case 8:
                    isPropOwnerTab = true;
                    break;
                case 9:
                    isPropImprovementsTab = true;
                    break;
                case 10:
                    isPropHomeTeamTab = true;
                    break;
            }
        }

        private void HandleBookingEdit(int bookingId)
        {
            showleftPanel = false;
            selectedBookingId = bookingId;
            Task.Delay(1);
            showleftPanel = true;
            showCollapse = true;
            StateHasChanged();
        }


        protected override async Task OnInitializedAsync()
        {
            sharedEvents.OnBookingIdClicked += HandleBookingEdit;
        }

        protected async Task ShowTabs(int propId, string Name)
        {
            showTabs = false;
            selectedPropId = propId;
            await Task.Delay(1);
            showTabs = true;
            propName = Name;
            StateHasChanged();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddProperty>("Add Property", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Property args)
        {
            //  await DialogService.OpenAsync<EditProperty>("Edit Property", new Dictionary<string, object> { { "Propid", args.Propid } });
        }

        void Change(string text)
        {
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Property property)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteProperty(property.Propid);
                    if (deleteResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Error",
                    Detail = "Unable to delete Property"
                });
            }
        }


        private PropertyFiltersModel filterModel = new();
        private List<AgentStatusDropDownValues> statusList = new();

        private bool isFirstRender = true;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && isFirstRender)
            {
                isFirstRender = false;
                await LoadDropdownsAsync();
                StateHasChanged();
            }
        }

        protected async Task LoadDropdownsAsync()
        {
            statusList = await propertyService.GetStatusDropDownValues();
        }

        private async Task OnSearch()
        {
            var query = new Query
            {
                OrderBy = "PropId desc",
                Skip = 0,
                Top = 20
            };
            var result = await propertyService.GetPropertiesPagedAsync(query, filterModel);
            pagedProperties = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        private void OnReset()
        {
            filterModel = new PropertyFiltersModel();
        }
    }
}
