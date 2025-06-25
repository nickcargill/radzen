using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.MarketingComponents.AffiliatesComponents
{
    public partial class AffiliatesTypes
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

        protected IEnumerable<Destination.Models.destinationTest.AffiliatesType> affiliatesTypes;

        protected RadzenDataGrid<Destination.Models.destinationTest.AffiliatesType> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            affiliatesTypes = await destinationTestService.GetAffiliatesTypes();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            affiliatesType = new Destination.Models.destinationTest.AffiliatesType();
        }

        protected async Task EditRow(Destination.Models.destinationTest.AffiliatesType args)
        {
            isEdit = true;
            affiliatesType = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.AffiliatesType affiliatesType)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteAffiliatesType(affiliatesType.Id);

                    if (deleteResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = $"Error",
                    Detail = $"Unable to delete AffiliatesType"
                });
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.AffiliatesType affiliatesType;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateAffiliatesType(affiliatesType.Id, affiliatesType) : await destinationTestService.CreateAffiliatesType(affiliatesType);

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