using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyRatesVrbos
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

        protected IEnumerable<Destination.Models.destinationTest.PropertyRatesVrbo> propertyRatesVrbos;

        protected RadzenDataGrid<Destination.Models.destinationTest.PropertyRatesVrbo> grid0;
        protected override async Task OnInitializedAsync()
        {
            propertyRatesVrbos = await destinationTestService.GetPropertyRatesVrbos(new Query { Expand = "Property" });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddPropertyRatesVrbo>("Add PropertyRatesVrbo", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.PropertyRatesVrbo args)
        {
            await DialogService.OpenAsync<EditPropertyRatesVrbo>("Edit PropertyRatesVrbo", new Dictionary<string, object> { {"Id", args.Id} });
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.PropertyRatesVrbo propertyRatesVrbo)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeletePropertyRatesVrbo(propertyRatesVrbo.Id);

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
                    Detail = $"Unable to delete PropertyRatesVrbo"
                });
            }
        }
    }
}