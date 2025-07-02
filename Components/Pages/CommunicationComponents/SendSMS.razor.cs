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
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Destination.Components.Pages.BookingComponents;

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class SendSMS
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
        protected OwnerService ownerService { get; set; }

        [Parameter]
        public int Id { get; set; }

        List<Smstemplate> smsTemplates = new List<Smstemplate>();

        Smstemplate smsTemplate = new Smstemplate();

        protected bool errorVisible;



        protected override async Task OnInitializedAsync()
        {
            smsTemplates = await ownerService.GetSMSTemplates();
        }

        protected async Task FormSubmit()
        {
            try
            {
                var records = await ownerService.GetOwnerRecordsAsync(Id, smsTemplate.TemplateId);

                if (records.Count == 0)
                    errorVisible = true;

                await ownerService.SendSmsToOwnersAsync(records, smsTemplate.StrTemplateContent);
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "SMS sent successfully!",
                    Duration = 4000 // in milliseconds
                });
                StateHasChanged();
            }
            catch (Exception ex)
            {
            }
        }
    }
}