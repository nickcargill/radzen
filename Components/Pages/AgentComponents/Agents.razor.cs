using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Components.Pages.BookingComponents;
using Destination.Models.destinationTest;
using Destination.Services;
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.AgentComponents
{
    public partial class Agents
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

        protected IEnumerable<Destination.Models.destinationTest.Agent> agents;

        protected RadzenDataGrid<Destination.Models.destinationTest.Agent> grid0;

        [Inject]
        public OwnerService ownerService { get; set; }

        private bool menuVisible = false;
        private string activeForm = "agent";
        protected bool showPanels = false;
        protected bool isBottomPanel = false;
        protected int selectedAgentId = 0;

        private bool isCollapsed = false;

        private bool showCollapse = true;

        private IEnumerable<Agent> pagedOwners;
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
        }

        private async Task LoadData(LoadDataArgs args)
        {
            var query = new Query
            {
                Filter = args.Filter,
                OrderBy = string.IsNullOrEmpty(args.OrderBy) ? "AgId desc" : args.OrderBy,
                Skip = args.Skip,
                Top = args.Top
            };

            var result = await ownerService.GetownersPagedAsync(query);

            pagedOwners = result.Items;
            totalCount = result.Count;
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            //await DialogService.OpenAsync<AddBooking>("Add Booking", null);
            //await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Agent args)
        {
            //  await DialogService.OpenAsync<EditBooking>("Edit Booking", new Dictionary<string, object> { {"Id", args.Id} });
        }

        protected async Task ShowPanels(int bookingId)
        {
            showPanels = false;
            selectedAgentId = bookingId;
            isBottomPanel = false;
            await Task.Delay(1);
            showPanels = true;
            showCollapse = true;
            isBottomPanel = true;
            StateHasChanged();
        }
        void Change(string text)
        {
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Agent agent)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteAgent(agent.AgId);

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
                    Detail = $"Unable to delete Agent"
                });
            }
        }

        private OwnerDto filterModel = new();
        private List<AgentStatusDropDownValues> statusList = new();

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
            statusList = await propertyService.GetAgentStatusDropDownValues();
        }

        private async Task OnSearch()
        {
            var query = new Query
            {
                OrderBy = "AgId",
                Skip = 0,
                Top = 20
            };
            var result = await ownerService.GetownersPagedAsync(query, filterModel);
            pagedOwners = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        private void OnReset()
        {
            filterModel = new OwnerDto();
        }
    }
}