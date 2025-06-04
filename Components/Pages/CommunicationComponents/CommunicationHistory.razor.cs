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
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;
using Destination.Models.destinationTest;

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class CommunicationHistory
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
        protected BookingService bookingService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected IEnumerable<CommunicationHistoryDto> commHistory;

        protected RadzenDataGrid<CommunicationHistoryDto> grid0;
        Communication commById = new Communication();

        protected IEnumerable<CommCode> commCodesForCommunication;

        protected bool isEdit = true;


        protected override async Task OnInitializedAsync()
        {
            commHistory = await bookingService.GetCommHistoryByBookingId(Id);
            commCodesForCommunication = await bookingService.GetAllCommCodes();
        }

        protected async Task BindCommunicationData(int id)
        {
            commById = await bookingService.GetCommunicationById(id);

            if (commById == null) {
                isEdit = false;
                commById = new Communication();
            }
            StateHasChanged();
        }

        protected async Task FormSubmit()
        {
            try
            {
                var result = await bookingService.CraeteOrUpdateCommunication(commById, isEdit);

                if (result)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Success",
                        Detail = "Annual logs updated successfully!",
                        Duration = 4000 // in milliseconds
                    });
                }

            }
            catch (Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Success",
                    Detail = "error while saving annual logs!",
                    Duration = 4000 // in milliseconds
                });
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}