using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingHistory
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
        protected BookingService bookingService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected IEnumerable<Destination.Shared.DTO.BookingHistoryResultDto> bookingHistoryResult;

        protected RadzenDataGrid<Destination.Shared.DTO.BookingHistoryResultDto> grid0;

        protected override async Task OnInitializedAsync()
        {
            bookingHistoryResult = await bookingService.GetBookingHistoryByBookingId(Id);
        }
    }
}