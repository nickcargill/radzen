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

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class SendEmail
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

        List<Template> emailTemplates = new List<Template>();

        Template emailTemplate = new Template();

        protected bool errorVisible;



        protected override async Task OnInitializedAsync()
        {
            emailTemplates = await ownerService.GetEmailTemplates();
        }

        protected async Task FormSubmit()
        {
            try
            {
                var result = await ownerService.SendEmailAsync(Id, emailTemplate.IntTemplateId, emailTemplate.StrTemplateContent);

                if(result == 1)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Success",
                        Detail = "Email sent successfully!",
                        Duration = 4000 // in milliseconds
                    });
                }

                StateHasChanged();
            }
            catch (Exception ex)
            {
            }
        }
    }
}