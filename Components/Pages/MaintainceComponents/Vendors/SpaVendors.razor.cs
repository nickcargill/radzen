using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.MaintainceComponents.Vendors
{
    public partial class SpaVendors
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

        protected IEnumerable<Destination.Models.destinationTest.PropertyCleaner> propertyCleaners;

        protected RadzenDataGrid<Destination.Models.destinationTest.PropertyCleaner> grid0;
        protected bool isEdit = true;

        protected string search = "";

        protected async Task Search(ChangeEventArgs args)
        {
            search = $"{args.Value}";

            await grid0.GoToPage(0);

            propertyCleaners = await destinationTestService.GetPropertyCleaners(new Query { Filter = $@"i => i.Firstname.Contains(@0) || i.Lastname.Contains(@0) || i.Email.Contains(@0) || i.Phone.Contains(@0) || i.Address.Contains(@0) || i.City.Contains(@0) || i.State.Contains(@0) || i.Zip.Contains(@0) || i.Notes.Contains(@0) || i.Status.Contains(@0) || i.Occupation.Contains(@0) || i.Resume.Contains(@0) || i.Sms.Contains(@0) || i.Login.Contains(@0) || i.Password.Contains(@0) || i.Photo.Contains(@0) || i.CompanyName.Contains(@0) || i.BusLic.Contains(@0)", FilterParameters = new object[] { search } });
        }
        protected override async Task OnInitializedAsync()
        {
            propertyCleaners = await destinationTestService.GetPropertyCleaners(new Radzen.Query { Filter = "i => i.Firstname.Contains(@0) || i.Lastname.Contains(@1) || i.Status == @2", FilterParameters = new object[] { search, search, "spa" } });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            propertyCleaner = new Destination.Models.destinationTest.PropertyCleaner();
        }

        protected async Task EditRow(Destination.Models.destinationTest.PropertyCleaner args)
        {
            isEdit = true;
            propertyCleaner = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.PropertyCleaner propertyCleaner)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeletePropertyCleaner(propertyCleaner.Cleanerid);

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
                    Detail = $"Unable to delete PropertyCleaner"
                });
            }
        }

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportPropertyCleanersToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "PropertyCleaners");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportPropertyCleanersToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "PropertyCleaners");
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.PropertyCleaner propertyCleaner;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdatePropertyCleaner(propertyCleaner.Cleanerid, propertyCleaner) : await destinationTestService.CreatePropertyCleaner(propertyCleaner);

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