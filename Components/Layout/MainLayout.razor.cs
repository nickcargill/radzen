using System.Net.Http;
using System.Security.Claims;
using Destination.Models.destinationTest;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
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

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject] 
        protected ProtectedLocalStorage LocalStorage { get; set; }

        [Inject]
        protected CustomAuthStateProvider AuthProvider { get; set; }



        protected List<MenuMaster> menuItems;
        protected int userRole = 0;

        protected override async Task OnInitializedAsync()
        {
            if (menuItems == null || menuItems.Count() == 0)
            {
                menuItems = await destinationTestService.GetAllMenus();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                var user = authState.User;

                if (user.Identity?.IsAuthenticated ?? false)
                {
                    var userIdClaim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                    if (int.TryParse(userIdClaim, out var id))
                    {
                        userRole = id;
                        StateHasChanged();
                    }
                }
            }
        }

        void SidebarToggleClick()
        {
            sidebarExpanded = !sidebarExpanded;
        }

        protected void Logout()
        {
            NavigationManager.NavigateTo("/", forceLoad: true);
        }

        private RenderFragment BuildMenuItem(MenuMaster item) => builder =>
        {
            var children = menuItems
                .Where(c => c.ParentId == item.Id && c.Role <= userRole)
                .OrderBy(c => c.SortOrder == null ? int.MaxValue : c.SortOrder)
                .ToList();

            builder.OpenComponent<RadzenPanelMenuItem>(0);

            if (item.UrlTarget == "_blank")
            {
                builder.AddAttribute(1, "Template", (RenderFragment)(templateBuilder =>
                {
                    templateBuilder.OpenElement(0, "a");
                    templateBuilder.AddAttribute(1, "href", item.MenuUrl);
                    templateBuilder.AddAttribute(2, "target", "_blank");

                    // Apply Radzen styling to match normal menu items
                    templateBuilder.AddAttribute(3, "class", "rz-panel-menu-item-link");
                    templateBuilder.AddAttribute(4, "style", "color: inherit; text-decoration: none;");

                    templateBuilder.OpenElement(5, "span");
                    templateBuilder.AddAttribute(6, "class", "rz-panel-menu-item-text");
                    templateBuilder.AddContent(7, item.MenuText);
                    templateBuilder.CloseElement(); // span

                    templateBuilder.CloseElement(); // a
                }));
            }
            else
            {
                builder.AddAttribute(8, "Text", item.MenuText);
                builder.AddAttribute(9, "Path", item.MenuUrl);
            }

            if (children.Any())
            {
                builder.AddAttribute(10, "ChildContent", (RenderFragment)(childBuilder =>
                {
                    foreach (var child in children)
                    {
                        childBuilder.AddContent(11, BuildMenuItem(child));
                    }
                }));
            }

            builder.CloseComponent();
        };


    }
}
