using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Components.Pages.BookingComponents;
using Destination.Models.destinationTest;
using Destination.Services;
using Destination.Shared.DTO;
using Microsoft.AspNetCore.WebUtilities;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.TenantComponents
{
    public partial class BookingsHistoryByTenant
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
        public int Id { get; set; } = 0;

        [Inject]
        public SharedEvents sharedEvents { get; set; }

        public EventCallback<int> OnIdClickedFromTenantHist { get; set; }

        protected RadzenDataGrid<Destination.Models.destinationTest.Booking> grid0;

        private IEnumerable<Booking> pagedBookings;
        private int totalCount;


        void PickedColumnsChanged(DataGridPickedColumnsChangedEventArgs<Destination.Models.destinationTest.Booking> args)
        {
        }

        protected async Task ShowPanels(int Id)
        {
            await OnIdClickedFromTenantHist.InvokeAsync(Id);
            sharedEvents.NotifyIdClickedFromTenantHistory(Id);
            StateHasChanged();
        }
        private async Task LoadData(LoadDataArgs args)
        {
            var query = new Query
            {
                Filter = args.Filter,
                OrderBy = string.IsNullOrEmpty(args.OrderBy) ? "Id desc" : args.OrderBy,
                Skip = args.Skip,
                Top = args.Top
            };

            var result = await bookingService.GetBookingsByTenantIdAsync(query, Id);

            pagedBookings = result.Items;
            totalCount = result.Count;
            StateHasChanged();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Booking args)
        {
            //  await DialogService.OpenAsync<EditBooking>("Edit Booking", new Dictionary<string, object> { {"Id", args.Id} });
        }
    }
}