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
    public partial class TblHomePageImagesLinks
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

        protected IEnumerable<Destination.Models.destinationTest.TblHomePageImagesLink> tblHomePageImagesLinks;

        protected RadzenDataGrid<Destination.Models.destinationTest.TblHomePageImagesLink> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            tblHomePageImagesLinks = await destinationTestService.GetTblHomePageImagesLinks();
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.TblHomePageImagesLink tblHomePageImagesLink;

        protected async Task FormSubmit()
        {
            try
            {

            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {

        }
    }
}