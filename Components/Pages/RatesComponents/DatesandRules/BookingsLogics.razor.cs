using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.RatesComponents.DatesandRules
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
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            bookingsLogics = await destinationTestService.GetBookingsLogics(new Query { Expand = "Property" });

            propertiesForIntPropId = await destinationTestService.GetProperties();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            bookingsLogic = new Destination.Models.destinationTest.BookingsLogic();
        }

        protected async Task EditRow(Destination.Models.destinationTest.BookingsLogic args)
        {
            isEdit = true;
            bookingsLogic = args;
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
        protected bool errorVisible;
        protected Destination.Models.destinationTest.BookingsLogic bookingsLogic;

        protected IEnumerable<Destination.Models.destinationTest.Property> propertiesForIntPropId;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateBookingsLogic(bookingsLogic.IntLogicId, bookingsLogic) : await destinationTestService.CreateBookingsLogic(bookingsLogic);

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