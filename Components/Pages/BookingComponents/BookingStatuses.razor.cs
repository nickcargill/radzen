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
    public partial class BookingStatuses
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

        protected IEnumerable<Destination.Models.destinationTest.BookingStatus> bookingStatuses;

        protected RadzenDataGrid<Destination.Models.destinationTest.BookingStatus> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            bookingStatuses = await destinationTestService.GetBookingStatuses();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            bookingStatus = new Destination.Models.destinationTest.BookingStatus();
        }

        protected async Task EditRow(Destination.Models.destinationTest.BookingStatus args)
        {
            isEdit = true;
            bookingStatus = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.BookingStatus bookingStatus)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteBookingStatus(bookingStatus.Id);

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
                    Detail = $"Unable to delete BookingStatus"
                });
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.BookingStatus bookingStatus;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateBookingStatus(bookingStatus.Id, bookingStatus) : await destinationTestService.CreateBookingStatus(bookingStatus);

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