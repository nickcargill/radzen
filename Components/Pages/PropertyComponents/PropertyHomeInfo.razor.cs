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
    public partial class PropertyHomeInfo
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

    private bool hasError = false;
    private string errorMessage = string.Empty;
    private PropertyInstructionsModel propertyInstructionsModel = new PropertyInstructionsModel();

    private async Task UpdateInstructions()
    {
        try
        {
            // Save logic here
            hasError = false;
        }
        catch (Exception ex)
        {
            hasError = true;
            errorMessage = ex.Message;
        }
    }

    private class PropertyInstructionsModel
    {
        public string HomeGuide { get; set; }
        public string ClosingInstructions { get; set; }
        public string MaintenanceInfo { get; set; }
        public string PrivateInstructions { get; set; }
    }
    }
}