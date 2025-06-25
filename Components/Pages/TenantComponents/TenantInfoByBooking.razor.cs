using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;
using Destination.Models.destinationTest;

namespace Destination.Components.Pages.TenantComponents
{
    public partial class TenantInfoByBooking
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
        public TenantService tenantService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        protected bool errorVisible;
        protected Destination.Models.destinationTest.Tenant tenant;

        [Parameter]
        public int Id { get; set; }

        protected string Name { get; set; }

        protected override async Task OnInitializedAsync()
        {
            tenant = await tenantService.GetTenantInfoByBookingId(Id);
            if (tenant != null) { 
                Name = tenant.Firstname +" "+ tenant.Lastname;
            }
        }

        protected async Task FormSubmit()
        {
            try
            {
                var result = await destinationTestService.UpdateTenant(tenant.Tenantid, tenant);
                if (result != null)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Success",
                        Detail = "Data updated successfully!",
                        Duration = 4000 // in milliseconds
                    });
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }
    }
}