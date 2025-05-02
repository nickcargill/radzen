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


namespace Destination.Components.Pages
{
    public partial class StatementsMenu
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

        [Inject]
        public ComponentLoaderService componentLoaderService { get; set; }

        private (Type Type, Dictionary<string, object> Parameters)? loadedComponent;


        protected bool shouldExpand = false;
        protected HashSet<int> expandedItems = new();
        
        protected List<MenuMasterDTO> menuItems;
        protected MenuMasterDTO menuItem;

        protected string selectedUrl;


        protected override async Task OnInitializedAsync()
        {
            menuItems = await destinationTestService.GetMenuHierarchyByIdAsync(339);
        }

        private void Toggle(MenuMasterDTO item)
        {
            if (expandedItems.Contains(item.Id))
            {
                expandedItems.Remove(item.Id);
            }
            else
            {
                expandedItems.Add(item.Id);
            }
        }


        private bool IsExpanded(MenuMasterDTO item) => expandedItems.Contains(item.Id);

        private RenderFragment RenderMenuItem(MenuMasterDTO item, int level) => builder =>
        {
            builder.OpenElement(0, "li");
            builder.AddAttribute(1, "class", "list-group-item");

            // Menu label with toggle icon for items with children
            builder.OpenElement(2, "span");
            builder.AddAttribute(3, "class", "menu-label");

            if (item.Children?.Any() == true)
            {
                builder.OpenElement(4, "span");
                builder.AddAttribute(5, "class", "toggle-icon");
                builder.AddAttribute(6, "onclick", EventCallback.Factory.Create(this, () => Toggle(item)));
                builder.AddContent(7, IsExpanded(item) ? "▼" : "▶");
                builder.CloseElement();
            }

            // Menu text (link or plain text)
            if (!string.IsNullOrEmpty(item.MenuUrl))
            {
                builder.OpenElement(8, "span");
                builder.AddAttribute(9, "class", "menu-link");
                builder.AddAttribute(10, "onclick", EventCallback.Factory.Create(this, () => OpenInPanel(item.MenuUrl)));
                builder.AddContent(11, item.MenuText);
                builder.CloseElement();
            }
            else
            {
                builder.AddContent(12, item.MenuText);
            }

            builder.CloseElement(); // span.menu-label

            // Render children recursively if expanded
            if (item.Children?.Any() == true && IsExpanded(item))
            {
                builder.OpenElement(13, "ul");
                builder.AddAttribute(14, "class", $"list-group mt-2{(level > 0 ? " ms-3" : "")}");

                foreach (var child in item.Children)
                {
                    builder.AddContent(15, RenderMenuItem(child, level + 1));
                }

                builder.CloseElement(); // ul
            }

            builder.CloseElement(); // li
        };


        void OpenInPanel(string url)
        {
            selectedUrl = url;
            var componentType = componentLoaderService.GetComponentType(url);
        
            if (componentType != null)
            {
                loadedComponent = (
                    componentType,
                    new Dictionary<string, object>
                    {
                    }
                );
            }
        }

        void Change(string text)
        {
        }
    }
}