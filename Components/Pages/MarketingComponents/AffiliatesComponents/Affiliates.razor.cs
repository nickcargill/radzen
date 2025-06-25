using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace Destination.Components.Pages.MarketingComponents.AffiliatesComponents
{
    public partial class Affiliates
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

        protected IEnumerable<Destination.Models.destinationTest.Affiliate> affiliates;

        protected RadzenDataGrid<Destination.Models.destinationTest.Affiliate> grid0;
        protected bool isEdit = true;

        protected string search = "";

        protected async Task Search(ChangeEventArgs args)
        {
            search = $"{args.Value}";

            await grid0.GoToPage(0);

            affiliates = await destinationTestService.GetAffiliates(new Query { Filter = $@"i => i.Name.Contains(@0) || i.Phone.Contains(@0) || i.Address.Contains(@0) || i.Website.Contains(@0) || i.Email.Contains(@0) || i.Password.Contains(@0) || i.Status.Contains(@0) || i.AffiliateCode.Contains(@0) || i.FindCabinContent.Contains(@0) || i.Type.Contains(@0) || i.City.Contains(@0) || i.State.Contains(@0) || i.Zip.Contains(@0) || i.Notes.Contains(@0) || i.PrimaryRepresentative.Contains(@0) || i.Priority.Contains(@0) || i.InstagramHandle.Contains(@0) || i.InstagramFollowers.Contains(@0) || i.FacebookUrl.Contains(@0) || i.FacebookFollowers.Contains(@0) || i.TiktokHandle.Contains(@0) || i.YoutubeChannel.Contains(@0) || i.YoutubeSubscribers.Contains(@0) || i.LinkingPage.Contains(@0) || i.WebsiteAuthority.Contains(@0) || i.HomepageMsg1.Contains(@0) || i.HomepageMsg2.Contains(@0) || i.MsgLink.Contains(@0) || i.Market.Contains(@0) || i.Title.Contains(@0) || i.ShortDescription.Contains(@0)", FilterParameters = new object[] { search } });
        }
        protected override async Task OnInitializedAsync()
        {
            affiliates = await destinationTestService.GetAffiliates(new Query { Filter = $@"i => i.Name.Contains(@0) || i.Phone.Contains(@0) || i.Address.Contains(@0) || i.Website.Contains(@0) || i.Email.Contains(@0) || i.Password.Contains(@0) || i.Status.Contains(@0) || i.AffiliateCode.Contains(@0) || i.FindCabinContent.Contains(@0) || i.Type.Contains(@0) || i.City.Contains(@0) || i.State.Contains(@0) || i.Zip.Contains(@0) || i.Notes.Contains(@0) || i.PrimaryRepresentative.Contains(@0) || i.Priority.Contains(@0) || i.InstagramHandle.Contains(@0) || i.InstagramFollowers.Contains(@0) || i.FacebookUrl.Contains(@0) || i.FacebookFollowers.Contains(@0) || i.TiktokHandle.Contains(@0) || i.YoutubeChannel.Contains(@0) || i.YoutubeSubscribers.Contains(@0) || i.LinkingPage.Contains(@0) || i.WebsiteAuthority.Contains(@0) || i.HomepageMsg1.Contains(@0) || i.HomepageMsg2.Contains(@0) || i.MsgLink.Contains(@0) || i.Market.Contains(@0) || i.Title.Contains(@0) || i.ShortDescription.Contains(@0)", FilterParameters = new object[] { search } });
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await grid0.SelectRow(null);
            isEdit = false;
            affiliate = new Destination.Models.destinationTest.Affiliate();
        }

        protected async Task EditRow(Destination.Models.destinationTest.Affiliate args)
        {
            isEdit = true;
            affiliate = args;
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Affiliate affiliate)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteAffiliate(affiliate.AffiliateId);

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
                    Detail = $"Unable to delete Affiliate"
                });
            }
        }

        protected async Task ExportClick(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await destinationTestService.ExportAffiliatesToCSV(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "Affiliates");
            }

            if (args == null || args.Value == "xlsx")
            {
                await destinationTestService.ExportAffiliatesToExcel(new Query
                {
                    Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}",
                    OrderBy = $"{grid0.Query.OrderBy}",
                    Expand = "",
                    Select = string.Join(",", grid0.ColumnsCollection.Where(c => c.GetVisible() && !string.IsNullOrEmpty(c.Property)).Select(c => c.Property.Contains(".") ? c.Property + " as " + c.Property.Replace(".", "") : c.Property))
                }, "Affiliates");
            }
        }
        protected bool errorVisible;
        protected Destination.Models.destinationTest.Affiliate affiliate;

        protected async Task FormSubmit()
        {
            try
            {
                var result = isEdit ? await destinationTestService.UpdateAffiliate(affiliate.AffiliateId, affiliate) : await destinationTestService.CreateAffiliate(affiliate);

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