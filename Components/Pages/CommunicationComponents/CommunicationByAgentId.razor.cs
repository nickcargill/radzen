using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Shared.DTO;
using Destination.Services;

namespace Destination.Components.Pages.CommunicationComponents
{
    public partial class CommunicationByAgentId
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

        List<OwnerCommunicationByAgentDTO> OwnerList = new List<OwnerCommunicationByAgentDTO>();

        OwnerCommunicationByAgentDTO data = new OwnerCommunicationByAgentDTO();
        protected override async Task OnInitializedAsync()
        {
            OwnerList = await ownerService.GetOwnersCommunicationByAgent(Id);
        }
    }
}