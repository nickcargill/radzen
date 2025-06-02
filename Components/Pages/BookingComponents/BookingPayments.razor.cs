using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingPayments
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

        [Inject]
        public BookingService bookingService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected IEnumerable<Destination.Models.destinationTest.Payment> payments;

        protected RadzenDataGrid<Destination.Models.destinationTest.Payment> grid0;
        protected override async Task OnInitializedAsync()
        {
            payments = await bookingService.GetPaymentsByBookingId(Id);
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddBookingPayments>("Add Payment", null);
            await grid0.Reload();
        }
    }
}