using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.ParentMenusComponents
{
    public partial class MenuManagements
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

        protected IEnumerable<Destination.Models.destinationTest.MenuManagement> menuManagements;

        protected RadzenDataGrid<Destination.Models.destinationTest.MenuManagement> grid0;
        protected override async Task OnInitializedAsync()
        {
            menuManagements = await destinationTestService.GetMenuManagements(new Query { Expand = "MenuMaster" });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddMenuManagement>("Add MenuManagement", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.MenuManagement args)
        {
            await DialogService.OpenAsync<EditMenuManagement>("Edit MenuManagement", new Dictionary<string, object> { {"Id", args.Id} });
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.MenuManagement menuManagement)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteMenuManagement(menuManagement.Id);

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
                    Detail = $"Unable to delete MenuManagement"
                });
            }
        }
    }
}