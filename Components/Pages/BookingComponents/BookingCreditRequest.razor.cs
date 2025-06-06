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
using static Destination.Shared.DTO.AllDropDownValues;
using Destination.Models.destinationTest;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingCreditRequest
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
        public BookingService bookingService { get; set; }

        CreditRequest creditRequest = new CreditRequest();

        protected bool isEdit = true;

        protected List<CreditRequestType> Types;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            creditRequest = await bookingService.GetCreditRequestByBookingId(Id);

            if (creditRequest == null) {
                creditRequest = new CreditRequest();
                creditRequest.BookingId = Id;
                isEdit = false;
            }

            Types = await bookingService.GetCreditRequestTypes();
        }

        private List<DropDownOption> avoidableOptions = new List<DropDownOption>
        {
            new DropDownOption { Value = "", Text = "Select Value" },
            new DropDownOption { Value = "Possibly", Text = "Possibly" },
            new DropDownOption { Value = "Yes", Text = "Yes Avoidable" },
            new DropDownOption { Value = "No", Text = "No not avoidable" }
        };
        public class DropDownOption
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }
        protected async Task Submit(CreditRequest arg)
        {
            var result = await bookingService.CraeteOrUpdateCreditRequests(arg,isEdit);
            if (result)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Data updated successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
        }
    }
}