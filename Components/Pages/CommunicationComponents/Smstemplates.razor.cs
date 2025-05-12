using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class Smstemplates
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

        protected IEnumerable<Destination.Models.destinationTest.Smstemplate> smstemplates;

        protected RadzenDataGrid<Destination.Models.destinationTest.Smstemplate> grid0;
        protected bool isEdit = true;
        protected override async Task OnInitializedAsync()
        {
            smstemplates = await destinationTestService.GetSmstemplates();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            smstemplate = new Destination.Models.destinationTest.Smstemplate();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Smstemplate args)
        {
            isEdit = true;
            smstemplate = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Smstemplate smstemplate)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteSmstemplate(smstemplate.TemplateId);

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
                    Detail = $"Unable to delete Smstemplate"
                });
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Smstemplate smstemplate;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateSmstemplate(smstemplate.TemplateId, smstemplate) : await destinationTestService.CreateSmstemplate(smstemplate);

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