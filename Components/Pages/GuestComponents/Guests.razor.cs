using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.GuestComponents
{
    public partial class Guests
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

        protected IEnumerable<Destination.Models.destinationTest.Tenant> tenants;

        protected RadzenDataGrid<Destination.Models.destinationTest.Tenant> grid0;
        protected bool isEdit = true;

        protected string search = "";

        protected async Task Search(ChangeEventArgs args)
        {
            search = $"{args.Value}";

            await grid0.GoToPage(0);

            tenants = await destinationTestService.GetTenants(new Query { Filter = $@"i => i.Firstname.Contains(@0) || i.Lastname.Contains(@0) || i.Phone.Contains(@0) || i.Cell.Contains(@0) || i.Email.Contains(@0) || i.Address.Contains(@0) || i.City.Contains(@0) || i.State.Contains(@0) || i.Zip.Contains(@0) || i.Notes.Contains(@0) || i.Remarks.Contains(@0) || i.Prebooknotes.Contains(@0) || i.Status.Contains(@0) || i.Password.Contains(@0) || i.Initials.Contains(@0) || i.ColorValue.Contains(@0) || i.AirbnbEmail.Contains(@0) || i.Dnrwhy.Contains(@0) || i.FetchedEmail.Contains(@0) || i.ThreadId.Contains(@0) || i.DoNotRentType.Contains(@0) || i.GuestPrimaryAddress.Contains(@0) || i.GuestCity.Contains(@0) || i.GuestState.Contains(@0) || i.GuestZip.Contains(@0) || i.LastPageVisited.Contains(@0)", FilterParameters = new object[] { search } });
        }
        protected override async Task OnInitializedAsync()
        {
            tenants = await destinationTestService.GetTenants(new Query { Filter = $@"i => i.Firstname.Contains(@0) || i.Lastname.Contains(@0) || i.Phone.Contains(@0) || i.Cell.Contains(@0) || i.Email.Contains(@0) || i.Address.Contains(@0) || i.City.Contains(@0) || i.State.Contains(@0) || i.Zip.Contains(@0) || i.Notes.Contains(@0) || i.Remarks.Contains(@0) || i.Prebooknotes.Contains(@0) || i.Status.Contains(@0) || i.Password.Contains(@0) || i.Initials.Contains(@0) || i.ColorValue.Contains(@0) || i.AirbnbEmail.Contains(@0) || i.Dnrwhy.Contains(@0) || i.FetchedEmail.Contains(@0) || i.ThreadId.Contains(@0) || i.DoNotRentType.Contains(@0) || i.GuestPrimaryAddress.Contains(@0) || i.GuestCity.Contains(@0) || i.GuestState.Contains(@0) || i.GuestZip.Contains(@0) || i.LastPageVisited.Contains(@0)", FilterParameters = new object[] { search } });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            tenant = new Destination.Models.destinationTest.Tenant();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Tenant args)
        {
            isEdit = true;
            tenant = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Tenant tenant)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteTenant(tenant.Tenantid);

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
                    Detail = $"Unable to delete Tenant"
                });
            }
        }

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportTenantsToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "Tenants");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportTenantsToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "Tenants");
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Tenant tenant;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateTenant(tenant.Tenantid, tenant) : await destinationTestService.CreateTenant(tenant);

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