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
    public partial class EditBookingsLogic
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

        [Parameter]
        public int IntLogicId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            bookingsLogic = await destinationTestService.GetBookingsLogicByIntLogicId(IntLogicId);

            propertiesForIntPropId = await destinationTestService.GetProperties();
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.BookingsLogic bookingsLogic;

        protected IEnumerable<Destination.Models.destinationTest.Property> propertiesForIntPropId;

        protected async Task FormSubmit()
        {
            try
            {
                await destinationTestService.UpdateBookingsLogic(IntLogicId, bookingsLogic);
                DialogService.Close(bookingsLogic);
            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}