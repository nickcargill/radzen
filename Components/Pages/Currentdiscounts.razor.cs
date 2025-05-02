using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages
{
    public partial class Currentdiscounts
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

        protected IEnumerable<Destination.Models.destinationTest.Currentdiscount> currentdiscounts;

        protected RadzenDataGrid<Destination.Models.destinationTest.Currentdiscount> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            currentdiscounts = await destinationTestService.GetCurrentdiscounts(new Query { Expand = "Property" });

            propertiesForPropid = await destinationTestService.GetProperties();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            currentdiscount = new Destination.Models.destinationTest.Currentdiscount();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Currentdiscount args)
        {
            isEdit = true;
            currentdiscount = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Currentdiscount currentdiscount)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteCurrentdiscount(currentdiscount.Specialsid);

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
                    Detail = $"Unable to delete Currentdiscount"
                });
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Currentdiscount currentdiscount;

        protected IEnumerable<Destination.Models.destinationTest.Property> propertiesForPropid;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateCurrentdiscount(currentdiscount.Specialsid, currentdiscount) : await destinationTestService.CreateCurrentdiscount(currentdiscount);

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