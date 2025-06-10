using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.UtilitiesComponents.Settings
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
        protected bool isEdit = true;

        protected string search = "";

        protected async Task Search(ChangeEventArgs args)
        {
            search = $"{args.Value}";

            await grid0.GoToPage(0);

            menuMasters = await destinationTestService.GetMenuMasters(new Query { Filter = $@"i => i.MenuText.Contains(@0) || i.MenuUrl.Contains(@0) || i.UrlTarget.Contains(@0) || i.Description.Contains(@0) || i.Location.Contains(@0) || i.QuerySchema.Contains(@0) || i.SchemaText.Contains(@0) || i.PageTitle.Contains(@0)", FilterParameters = new object[] { search } });
        }
        protected override async Task OnInitializedAsync()
        {
            menuMasters = await destinationTestService.GetMenuMasters(new Query { Filter = $@"i => i.MenuText.Contains(@0) || i.MenuUrl.Contains(@0) || i.UrlTarget.Contains(@0) || i.Description.Contains(@0) || i.Location.Contains(@0) || i.QuerySchema.Contains(@0) || i.SchemaText.Contains(@0) || i.PageTitle.Contains(@0)", FilterParameters = new object[] { search } });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            menuMaster = new Destination.Models.destinationTest.MenuMaster();
        }

        protected async Task EditRow(Destination.Models.destinationTest.MenuMaster args)
        {
            isEdit = true;
            menuMaster = args;
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

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportMenuMastersToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "MenuMasters");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportMenuMastersToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "MenuMasters");
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.MenuMaster menuMaster;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateMenuMaster(menuMaster.Id, menuMaster) : await destinationTestService.CreateMenuMaster(menuMaster);

            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {

        }
    }
}