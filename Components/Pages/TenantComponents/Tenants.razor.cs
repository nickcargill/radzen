using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Services;
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.TenantComponents
{
    public partial class Tenants
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

        protected IEnumerable<Destination.Models.destinationTest.Tenant> tenants;

        protected RadzenDataGrid<Destination.Models.destinationTest.Tenant> grid0;
        protected override async Task OnInitializedAsync()
        {
            //tenants = await destinationTestService.GetTenants();
        }

        [Inject]
        public TenantService tenantService { get; set; }

        private bool menuVisible = false;
        private string activeForm = "tenant";
        protected bool showPanels = false;
        protected int selectedTenantId = 0;

        private bool isCollapsed = false;

        private bool showCollapse = true;

        private IEnumerable<Tenant> pagedGuests;
        private int totalCount;


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

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddTenant>("Add Tenant", null);
            await grid0.Reload();
        }

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

        private async Task LoadData(LoadDataArgs args)
        {
            var query = new Query
            {
                Filter = args.Filter,
                OrderBy = string.IsNullOrEmpty(args.OrderBy) ? "Tenantid desc" : args.OrderBy,
                Skip = args.Skip,
                Top = args.Top
            };

            var result = await tenantService.GetTenantsPagedAsync(query);

            pagedGuests = result.Items;
            totalCount = result.Count;
        }

        protected async Task ShowPanels(int tenantId)
        {
            showPanels = false;
            selectedTenantId = tenantId;
            await Task.Delay(1);
            showPanels = true;
            showCollapse = true;
            StateHasChanged();
        }
        void Change(string text)
        {
        }

        private TenantFilterModel filterModel = new();
        List<int?> roles = new();

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
            roles = await tenantService.GetUserRoles();
        }
        private async Task OnSearch()
        {
            var query = new Query
            {
                OrderBy = "Tenantid",
                Skip = 0,
                Top = 20
            };
            var result = await tenantService.GetTenantsPagedAsync(query, filterModel);
            pagedGuests = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        private void OnReset()
        {
            filterModel = new TenantFilterModel();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Tenant args)
        {
            //await DialogService.OpenAsync<EditTenant>("Edit Tenant", new Dictionary<string, object> { {"Tenantid", args.Tenantid} });
        }
    }
}