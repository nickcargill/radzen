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
using Destination.Shared.DTO;
using Destination.Models.destinationTest;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyImprovements
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
        public PropertyService propertyService { get; set; }

        [Parameter]
        public int Id { get; set; }

        Property property = new Property();

        string propName = string.Empty;

        protected IEnumerable<PropertyImprovementDto> propertyImprovements;
        protected RadzenDataGrid<PropertyImprovementDto> grid0;


        protected override async Task OnInitializedAsync()
        {
            propertyImprovements = await propertyService.GetImprovementsByPropId(Id);

            property = await destinationTestService.GetPropertyByPropid(Id);

            if (property != null && !string.IsNullOrEmpty(property.Name))
            {
                propName = property.Name + " - " + "Improvements";
            }
            else
            {
                propName = "Improvements";
            }
        }
    }
}