using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.ParentMenusComponents
{
    public partial class AllMenus
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        protected List<Destination.Models.destinationTest.MenuMasterDTO> menuItems;

        protected Destination.Models.destinationTest.MenuMasterDTO menuItem;

        protected override async Task OnInitializedAsync()
        {
            menuItems = await destinationTestService.GetMenuHierarchyAsync();
        }
        
        bool ShouldExpandPropertyMenu(object data)
        {
            return false;
        }
}}