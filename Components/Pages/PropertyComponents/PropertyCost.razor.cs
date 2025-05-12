using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyCost
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

            private string errorMessage;
    private PropertyCostModel propertyCostModel = new PropertyCostModel();
    
    private List<DropdownOption> cleanerOptions = new List<DropdownOption>();
    private List<DropdownOption> ownerLoginOptions = new List<DropdownOption>();

    protected override async Task OnInitializedAsync()
    {
        // Load dropdown options
      //  cleanerOptions = await GetCleanerOptions();
       // ownerLoginOptions = await GetOwnerLoginOptions();
    }

    private async Task UpdatePropertyCost()
    {
        try
        {
            // Save logic here
            errorMessage = string.Empty;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }
    }

    private class PropertyCostModel
    {
        public decimal CleaningFeeId { get; set; }
        public string OwnerTextId { get; set; }
        public decimal SupplyCostId { get; set; }
        public decimal BidId { get; set; }
        public int CleanerId { get; set; }
        public int OwnerLoginId { get; set; }
        public decimal DepositId { get; set; }
        public DateTime? LastUpdateId { get; set; }
        public decimal MgtRateId { get; set; }
        public decimal LatId { get; set; }
        public decimal LongId { get; set; }
    }

    private class DropdownOption
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }
    }
}