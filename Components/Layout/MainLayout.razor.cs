using System.Net.Http;
using Destination.Models.destinationTest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Layout
{
    public partial class MainLayout
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

        private bool sidebarExpanded = true;

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        protected List<MenuMaster> menuItems;
        protected List<MenuMaster> menuItemss;

        protected override async Task OnInitializedAsync()
        {
           // menuItems = await destinationTestService.GetParentMenus();
            menuItems = await destinationTestService.GetAllMenus();
        }

        void SidebarToggleClick()
        {
            sidebarExpanded = !sidebarExpanded;
        }

        private RenderFragment BuildMenuItem(MenuMaster item) => builder =>
        {
            var children = menuItems.Where(c => c.ParentId == item.Id).OrderBy(c => c.MenuText).ToList();

            builder.OpenComponent<RadzenPanelMenuItem>(0);
            builder.AddAttribute(1, "Text", item.MenuText);
            builder.AddAttribute(2, "Path", item.MenuUrl);

            if (children.Any())
            {
                builder.AddAttribute(3, "ChildContent", (RenderFragment)(childBuilder =>
                {
                    foreach (var child in children)
                    {
                        childBuilder.AddContent(4, BuildMenuItem(child));
                    }
                }));
            }

            builder.CloseComponent();
        };
    }
}
