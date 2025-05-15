using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Components.Pages.BookingComponents;

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
    public SharedEvents sharedEvents { get; set; }

    protected IEnumerable<Property> properties;
    protected RadzenDataGrid<Property> grid0;
    protected bool showTabs = false;
    protected bool isRates = false;
    protected int selectedPropId = 0;
    protected int selectedBookingId = 0;

    protected bool isPropCostTab = false;
    protected bool isPropDescTab = false;
    protected bool isPropRatesTab = false;
    protected bool isPropHomeInfoTab = false;
    protected bool isPropBookingsTab = false;
    protected bool showleftPanel = false;

    private bool isCollapsed = false;

    private bool showCollapse = true;

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

    void PickedColumnsChanged(DataGridPickedColumnsChangedEventArgs<Destination.Models.destinationTest.Property> args)
    {
    }

    private void OnTabChange(int index)
    {
        switch(index)
        {
            case 1:
                isPropCostTab = true;
                break;
            case 2:
                isPropDescTab = true;
                break;
            case 3:
                isPropHomeInfoTab = true;
                break;
            case 4:
                isPropRatesTab = true;
                break;
            case 5:
                isPropBookingsTab = true;
                break;
        }
    }

    private void HandleBookingEdit(int bookingId)
    {
        showleftPanel = false;
        selectedBookingId = bookingId;
        Task.Delay(1);
        showleftPanel = true;
        StateHasChanged(); 
    }


    protected override async Task OnInitializedAsync()
    {
        properties = await destinationTestService.GetProperties(new Query { Expand = "Agent,Status1,PropertyCleaner" });
        sharedEvents.OnBookingIdClicked += HandleBookingEdit;
    }


    async void ShowContextMenuWithItems(MouseEventArgs args, Property item)
    {
        ContextMenuService.Open(args,
            new List<ContextMenuItem> {
                new ContextMenuItem(){ Text = "Property Details", Value = 1},
                new ContextMenuItem(){ Text = "Property Cost", Value = 2},
                new ContextMenuItem(){ Text = "Property Description", Value = 3},
                new ContextMenuItem(){ Text = "Home Info", Value = 4},
                new ContextMenuItem(){ Text = "Rates", Value = 5},
                new ContextMenuItem(){ Text = "All Bookings", Value = 6}

         }, OnMenuItemClick);
    }

    void OnMenuItemClick(MenuItemEventArgs args)
    {
        if(args.Value.Equals(3))
        {
          isRates = true;
        }

      showTabs = false;
      ContextMenuService.Close();
      StateHasChanged();
    }

    protected async Task ShowTabs(int propId)
    {
        showTabs = false;
        selectedPropId = propId;
        isRates = false;
        await Task.Delay(1);
        showTabs = true;
        StateHasChanged();
    }

    protected async Task AddButtonClick(MouseEventArgs args)
    {
        await DialogService.OpenAsync<AddProperty>("Add Property", null);
        await grid0.Reload();
    }

    protected async Task EditRow(Destination.Models.destinationTest.Property args)
    {
        await DialogService.OpenAsync<EditProperty>("Edit Property", new Dictionary<string, object> { { "Propid", args.Propid } });
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
}}
