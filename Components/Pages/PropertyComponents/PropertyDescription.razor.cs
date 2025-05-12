using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;

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

        [Parameter]
        public int Id { get; set; }

        protected Property property;


        protected override async Task OnInitializedAsync()
        {
            property = await destinationTestService.GetPropertyByPropid(Id);
        }

        private void OpenAirbnbLink()
        {
            // Open Airbnb link in new tab
        //   UriHelper.NavigateTo("https://www.airbnb.com/", true);
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

        private async Task UpdateDescriptions()
        {
            try
            {
                // Save logic here
            }
            catch (Exception ex)
            {
            }
        }
  }
}