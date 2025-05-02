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
    public partial class Owners2
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

        protected IEnumerable<Destination.Models.destinationTest.Agent> agents;

        protected RadzenDataGrid<Destination.Models.destinationTest.Agent> grid0;
        protected override async Task OnInitializedAsync()
        {
            agents = await destinationTestService.GetAgents();
        }

        protected async Task AddButtonClick(MouseEventArgs args)
        {
            await DialogService.OpenAsync<AddOwners2>("Add Agent", null);
            await grid0.Reload();
        }

        protected async Task EditRow(DataGridRowMouseEventArgs<Destination.Models.destinationTest.Agent> args)
        {
            await DialogService.OpenAsync<EditOwners2>("Edit Agent", new Dictionary<string, object> { {"AgId", args.Data.AgId} });
        }

        protected async Task GridDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Agent agent)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteAgent(agent.AgId);

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
                    Detail = $"Unable to delete Agent"
                });
            }
        }

        protected Destination.Models.destinationTest.Agent agentChild;
        protected async Task GetChildData(Destination.Models.destinationTest.Agent args)
        {
            agentChild = args;
            var OwnerCommunicationsResult = await destinationTestService.GetOwnerCommunications();
            if (OwnerCommunicationsResult != null)
            {
                args.OwnerCommunications = OwnerCommunicationsResult.ToList();
            }
            var PropertiesResult = await destinationTestService.GetProperties(new Query { Filter = $@"i => i.Agentid == {args.AgId}", Expand = "Agent,Status1,PropertyCleaner" });
            if (PropertiesResult != null)
            {
                args.Properties = PropertiesResult.ToList();
            }
        }
        protected Destination.Models.destinationTest.OwnerCommunication ownerCommunicationOwnerCommunications;

        protected IEnumerable<Destination.Models.destinationTest.Agent> agentsForOwneridOwnerCommunications;

        protected RadzenDataGrid<Destination.Models.destinationTest.OwnerCommunication> OwnerCommunicationsDataGrid;

        protected async Task OwnerCommunicationsAddButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Agent data)
        {

            var dialogResult = await DialogService.OpenAsync<AddOwnerCommunication>("Add OwnerCommunications", new Dictionary<string, object> {  });
            await GetChildData(data);
            await OwnerCommunicationsDataGrid.Reload();

        }

        protected async Task OwnerCommunicationsRowSelect(Destination.Models.destinationTest.OwnerCommunication args, Destination.Models.destinationTest.Agent data)
        {
            var dialogResult = await DialogService.OpenAsync<EditOwnerCommunication>("Edit OwnerCommunications", new Dictionary<string, object> { {"Id", args.Id} });
            await GetChildData(data);
            await OwnerCommunicationsDataGrid.Reload();
        }

        protected async Task OwnerCommunicationsDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.OwnerCommunication ownerCommunication)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteOwnerCommunication(ownerCommunication.Id);

                    await GetChildData(agentChild);

                    if (deleteResult != null)
                    {
                        await OwnerCommunicationsDataGrid.Reload();
                    }
                }
            }
            catch (System.Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = $"Error",
                    Detail = $"Unable to delete OwnerCommunication"
                });
            }
        }
        protected Destination.Models.destinationTest.Property propertyProperties;

        protected IEnumerable<Destination.Models.destinationTest.Agent> agentsForAgentidProperties;

        protected IEnumerable<Destination.Models.destinationTest.Status> statusesForStatusProperties;

        protected IEnumerable<Destination.Models.destinationTest.PropertyCleaner> propertyCleanersForCleanerassignedProperties;

        protected RadzenDataGrid<Destination.Models.destinationTest.Property> PropertiesDataGrid;

        protected async Task PropertiesAddButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Agent data)
        {

            var dialogResult = await DialogService.OpenAsync<AddProperty>("Add Properties", new Dictionary<string, object> { {"Agentid" , data.AgId} });
            await GetChildData(data);
            await PropertiesDataGrid.Reload();

        }

        protected async Task PropertiesRowSelect(Destination.Models.destinationTest.Property args, Destination.Models.destinationTest.Agent data)
        {
            var dialogResult = await DialogService.OpenAsync<EditProperty>("Edit Properties", new Dictionary<string, object> { {"Propid", args.Propid} });
            await GetChildData(data);
            await PropertiesDataGrid.Reload();
        }

        protected async Task PropertiesDeleteButtonClick(MouseEventArgs args, Destination.Models.destinationTest.Property property)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var deleteResult = await destinationTestService.DeleteProperty(property.Propid);

                    await GetChildData(agentChild);

                    if (deleteResult != null)
                    {
                        await PropertiesDataGrid.Reload();
                    }
                }
            }
            catch (System.Exception ex)
            {
                NotificationService.Notify(new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = $"Error",
                    Detail = $"Unable to delete Property"
                });
            }
        }

        string lastFilter;
        protected async void Grid0Render(DataGridRenderEventArgs<Destination.Models.destinationTest.Agent> args)
        {
            if (grid0.Query.Filter != lastFilter)
            {
                agentChild = grid0.View.FirstOrDefault();
            }

            if (grid0.Query.Filter != lastFilter && agentChild != null)
            {
                await grid0.SelectRow(agentChild);
            }

            lastFilter = grid0.Query.Filter;
        }
    }
}