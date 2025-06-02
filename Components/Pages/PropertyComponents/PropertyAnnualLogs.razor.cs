using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Destination.Services;
using Destination.Shared.DTO;
using static Destination.Shared.DTO.AllDropDownValues;

namespace Destination.Components.Pages.PropertyComponents
{
    public partial class PropertyAnnualLogs
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

        protected IEnumerable<PropertyAnnualLogDto> annuals;

        protected RadzenDataGrid<PropertyAnnualLogDto> grid0;
        PropertyAnnualLogDto annualLogsById = new PropertyAnnualLogDto();
        protected IEnumerable<PropertyDropDownData> propertiesForPropid;


        protected override async Task OnInitializedAsync()
        {
            annuals = await propertyService.GetPropertyAnnualLogs(Id);
            propertiesForPropid = await propertyService.GetPropertiesForDropDown();
        }

        protected async Task BindAnnualLogs(int id)
        {
            annualLogsById = annuals.Where(x => x.ID == id).FirstOrDefault();
            StateHasChanged();
        }

        protected async Task FormSubmit()
        {
            try
            {
                await propertyService.UpdatePropertyAnnualLogs(annualLogsById);
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Success",
                    Detail = "Annual logs updated successfully!",
                    Duration = 4000 // in milliseconds
                });
            }
            catch (Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Success",
                    Detail = "error while saving annual logs!",
                    Duration = 4000 // in milliseconds
                });
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}