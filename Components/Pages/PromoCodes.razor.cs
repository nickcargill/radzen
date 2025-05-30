using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages
{
    public partial class PromoCodes
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

        protected IEnumerable<Destination.Models.destinationTest.PromoCode> promoCodes;

        protected RadzenDataGrid<Destination.Models.destinationTest.PromoCode> grid0;
        protected bool isEdit = true;

        protected string search = "";

        protected async Task Search(ChangeEventArgs args)
        {
            search = $"{args.Value}";

            await grid0.GoToPage(0);

            promoCodes = await destinationTestService.GetPromoCodes(new Query { Filter = $@"i => i.PromoCode1.Contains(@0) || i.DiscountType.Contains(@0)", FilterParameters = new object[] { search }, Expand = "Property" });
        }
        protected override async Task OnInitializedAsync()
        {
            promoCodes = await destinationTestService.GetPromoCodes(new Query { Filter = $@"i => i.PromoCode1.Contains(@0) || i.DiscountType.Contains(@0)", FilterParameters = new object[] { search }, Expand = "Property" });

            propertiesForPropId = await destinationTestService.GetProperties();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            promoCode = new Destination.Models.destinationTest.PromoCode();
        }

        protected async Task EditRow(Destination.Models.destinationTest.PromoCode args)
        {
            isEdit = true;
            promoCode = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.PromoCode promoCode)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeletePromoCode(promoCode.Id);

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
                    Detail = $"Unable to delete PromoCode"
                });
            }
        }

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportPromoCodesToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "Property",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "PromoCodes");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportPromoCodesToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "Property",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "PromoCodes");
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.PromoCode promoCode;

        protected IEnumerable<Destination.Models.destinationTest.Property> propertiesForPropId;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdatePromoCode(promoCode.Id, promoCode) : await destinationTestService.CreatePromoCode(promoCode);

            }
            catch (Exception ex)
            {
                errorVisible = true;
            }
        }

        protected async Task CancelButtonClick(MouseEventArgs args)
        {

        }
    }
}