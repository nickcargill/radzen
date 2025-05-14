using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.ChannelComponents
{
    public partial class Channels
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

        protected IEnumerable<Destination.Models.destinationTest.Channel> channels;

        protected bool showPanels = false;
        protected int selectedChannelId = 0;

        protected RadzenDataGrid<Destination.Models.destinationTest.Channel> grid0;

        private bool isCollapsed = false;

        private bool showCollapse = true;

        private void ShowCollapse()
        {
            showCollapse = true;
            showPanels = true;
        }

        private void HidePanel()
        {
            showCollapse = false;
            showPanels = false;
        }
        protected override async Task OnInitializedAsync()
        {
            channels = await destinationTestService.GetChannels(new Query { Expand = "Property" });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddChannel>("Add Channel", null);
            await grid0.Reload();
        }

        protected async Task ShowPanels(int channelId)
        {
            showPanels = false;
            selectedChannelId = channelId;
            await Task.Delay(1);
            showPanels = true;
            StateHasChanged();
        }

        void Change(string text)
        {
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Channel channel)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteChannel(channel.Id);

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
                    Detail = $"Unable to delete Channel"
                });
            }
        }
    }
}