using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Models.destinationTest;

namespace Destination.Components.Pages
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

    protected IEnumerable<Property> properties;
    protected RadzenDataGrid<Property> grid0;
    protected bool showTabs = false;
    protected int selectedPropid = 0;
    protected bool errorVisible;
    protected PropertyRate propertyRate;
    protected IEnumerable<Property> propertiesForPropid;
    protected bool isLoading = false;
    protected bool loadError = false;
    protected int selectedPropertyId = 3;

    protected bool isRates = false;
    protected bool shouldExpand = false;
    
    bool ShouldExpandPropertyMenu(object data)
    {
        return false;
    }


    protected override async Task OnInitializedAsync()
    {
        properties = await destinationTestService.GetProperties(new Query { Expand = "Agent,Status1,PropertyCleaner" });
       // propertiesForPropid = await destinationTestService.GetProperties();
    }


    async void ShowContextMenuWithItems(MouseEventArgs args, Property item)
    {
        ContextMenuService.Open(args,
            new List<ContextMenuItem> {
                new ContextMenuItem(){ Text = "Edit Info", Value = 1},
                new ContextMenuItem(){ Text = "Home Info", Value = 2},
                new ContextMenuItem(){ Text = "Rates", Value = 3},
                new ContextMenuItem(){ Text = "Bookings", Value = 4},
                new ContextMenuItem(){ Text = "Desc", Value = 5}

         }, OnMenuItemClick);
    }

    void Change(string text)
    {
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
        selectedPropid = propId;
        showTabs = true;
        propertyRate = null; // Reset to trigger loading on tab change
        isLoading = false;
        loadError = false;
        isRates = false;
      //  propertyRate = await destinationTestService.GetPropertyRateById(selectedPropid);
        StateHasChanged();
    }

    protected async Task CancelButtonClick()
    {
        propertyRate = null;
        showTabs = false;
        errorVisible = false;
        isLoading = false;
        loadError = false;
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
