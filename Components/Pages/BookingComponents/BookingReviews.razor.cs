using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Services;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore.SqlServer.Update.Internal;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingReviews
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

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected Destination.Models.destinationTest.Review review;

        private bool isupdate = true;

        protected override async Task OnInitializedAsync()
        {
            review = await bookingService.GetReviewsByBookingId(Id);

            if (review == null) {
                isupdate = false;
                review = new Review();
                review.Bookingid = Id;
            }
        }

        protected bool errorVisible;

        private async Task FormSubmit()
        {
            try
            {
                if (isupdate) {
                    await destinationTestService.UpdateReview(review.Id, review);
                }
                else{
                    await destinationTestService.CreateReview(review);
                }
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Data updated successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }
    }
}