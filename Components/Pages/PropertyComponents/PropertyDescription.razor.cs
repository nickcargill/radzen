using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Services;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyDescription
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

        [Parameter]
        public int Id { get; set; }

        Property property = new Property();


        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);
        }

        private void OpenAirbnbLink()
        {
           NavigationManager.NavigateTo("https://www.airbnb.com/");
        }

        private async Task SyncToAirbnb()
        {
            try
            {
                // Sync logic here
            }
            catch (Exception ex)
            {
            }
        }

        protected async Task Submit(Property arg)
        {
            var result = await propertyService.Updateproperty(arg);
            if (result)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Data updated successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
        }
    }
}