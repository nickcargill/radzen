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
    public partial class AffiliatesPropertyViewHistories
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

        protected IEnumerable<Destination.Models.destinationTest.AffiliatesPropertyViewHistory> affiliatesPropertyViewHistories;

        protected RadzenDataGrid<Destination.Models.destinationTest.AffiliatesPropertyViewHistory> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            affiliatesPropertyViewHistories = await destinationTestService.GetAffiliatesPropertyViewHistories();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            affiliatesPropertyViewHistory = new Destination.Models.destinationTest.AffiliatesPropertyViewHistory();
        }

        protected async Task EditRow(Destination.Models.destinationTest.AffiliatesPropertyViewHistory args)
        {
            isEdit = true;
            affiliatesPropertyViewHistory = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.AffiliatesPropertyViewHistory affiliatesPropertyViewHistory)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteAffiliatesPropertyViewHistory(affiliatesPropertyViewHistory.Id);

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
                    Detail = $"Unable to delete AffiliatesPropertyViewHistory"
                });
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.AffiliatesPropertyViewHistory affiliatesPropertyViewHistory;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateAffiliatesPropertyViewHistory(affiliatesPropertyViewHistory.Id, affiliatesPropertyViewHistory) : await destinationTestService.CreateAffiliatesPropertyViewHistory(affiliatesPropertyViewHistory);

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