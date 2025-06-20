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
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.BookingComponents
{
    public partial class BookingNotes
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
        protected destinationTestService destinationTestService { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Booking bookingNotes = new();

        protected bool errorVisible;
        protected IEnumerable<PropertyDropDownData> propertiesForPropertyid;

        protected IEnumerable<BookingStatusDropDownData> bookingStatusesForStatusid;
        protected IEnumerable<Destination.Models.destinationTest.PropertySource> propertySourcesForSourceid;

        protected override async Task OnInitializedAsync()
        {
            bookingNotes = await destinationTestService.GetBookingById(Id);
            bookingStatusesForStatusid = await destinationTestService.GetBookingStatusesForDropDown();
            propertiesForPropertyid = await destinationTestService.GetPropertiesForDropDown();
            propertySourcesForSourceid = await destinationTestService.GetPropertySources();
        }

        private async Task FormSubmit()
        {
            try
            {
                await destinationTestService.UpdateBooking(Id, bookingNotes);
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


        private List<SelectItem> agentList = new List<SelectItem>
        {
            new SelectItem { Value = "", Name = "Select Value" },
            new SelectItem { Value = "April", Name = "April" },
            new SelectItem { Value = "Christal", Name = "Christal" },
            new SelectItem { Value = "Evan", Name = "Evan" },
            new SelectItem { Value = "Tristan", Name = "Tristan" },
            new SelectItem { Value = "Kenny", Name = "Kenny" },
            new SelectItem { Value = "Meg", Name = "Meg" },
            new SelectItem { Value = "Mel", Name = "Mel" },
            new SelectItem { Value = "Nick", Name = "Nick" },
            new SelectItem { Value = "Wendy", Name = "Wendy" },
            new SelectItem { Value = "Pat", Name = "Pat" }
        };

        public class SelectItem
        {
            public string Value { get; set; }
            public string Name { get; set; }
        }

        private void OnCancel()
        {
            NavigationManager.NavigateTo("/bookings");
        }
    }
}
