using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages
{
    public partial class EditDiscount
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
        public int Discountid { get; set; }

        protected override async Task OnInitializedAsync()
        {
            discount = await destinationTestService.GetDiscountByDiscountid(Discountid);
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Discount discount;

        protected async Task FormSubmit()
        {
            try
            {
                await destinationTestService.UpdateDiscount(Discountid, discount);
                DialogService.Close(discount);
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