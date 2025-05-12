using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.AgentComponents
{
    public partial class EditOwnerCommunication
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
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ownerCommunication = await destinationTestService.GetOwnerCommunicationById(Id);

            agentsForOwnerid = await destinationTestService.GetAgents();
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.OwnerCommunication ownerCommunication;

        protected IEnumerable<Destination.Models.destinationTest.Agent> agentsForOwnerid;

        protected async Task FormSubmit()
        {
            try
            {
                await destinationTestService.UpdateOwnerCommunication(Id, ownerCommunication);
                DialogService.Close(ownerCommunication);
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





        bool hasOwneridValue;

        [Parameter]
        public int? Ownerid { get; set; }
        public override async Task SetParametersAsync(ParameterView parameters)
        {
            ownerCommunication = new Destination.Models.destinationTest.OwnerCommunication();

            hasOwneridValue = parameters.TryGetValue<int?>("Ownerid", out var hasOwneridResult);

            if (hasOwneridValue)
            {
                ownerCommunication.Ownerid = hasOwneridResult;
            }
            await base.SetParametersAsync(parameters);
        }
    }
}