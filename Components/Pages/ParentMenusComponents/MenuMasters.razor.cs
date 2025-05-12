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
    public partial class MenuMasters
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

        protected IEnumerable<Destination.Models.destinationTest.MenuMaster> menuMasters;

        protected RadzenDataGrid<Destination.Models.destinationTest.MenuMaster> grid0;
        protected override async Task OnInitializedAsync()
        {
            menuMasters = await destinationTestService.GetMenuMasters();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddMenuMaster>("Add MenuMaster", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.MenuMaster args)
        {
            await DialogService.OpenAsync<EditMenuMaster>("Edit MenuMaster", new Dictionary<string, object> { {"Id", args.Id} });
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.MenuMaster menuMaster)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteMenuMaster(menuMaster.Id);

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
                    Detail = $"Unable to delete MenuMaster"
                });
            }
        }
    }
}