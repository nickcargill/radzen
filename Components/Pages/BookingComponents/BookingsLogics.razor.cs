using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingsLogics
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

        protected IEnumerable<Destination.Models.destinationTest.BookingsLogic> bookingsLogics;

        protected RadzenDataGrid<Destination.Models.destinationTest.BookingsLogic> grid0;
        protected override async Task OnInitializedAsync()
        {
            bookingsLogics = await destinationTestService.GetBookingsLogics(new Query { Expand = "Property" });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddBookingsLogic>("Add BookingsLogic", null);
            await grid0.Reload();
        }

        protected async Task EditRow(Destination.Models.destinationTest.BookingsLogic args)
        {
            await DialogService.OpenAsync<EditBookingsLogic>("Edit BookingsLogic", new Dictionary<string, object> { {"IntLogicId", args.IntLogicId} });
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.BookingsLogic bookingsLogic)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteBookingsLogic(bookingsLogic.IntLogicId);

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
                    Detail = $"Unable to delete BookingsLogic"
                });
            }
        }

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportBookingsLogicsToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "Property",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "BookingsLogics");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportBookingsLogicsToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "Property",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "BookingsLogics");
            }
        }
    }
}