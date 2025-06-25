using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using Destination.Models.destinationTest;
using Destination.Services;

namespace Destination.Components.Pages.HomeTeamComponents
{
    public partial class HomeTeamForm
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
        protected PropertyService propertyService { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected PropertyMgt propertyMgt = new PropertyMgt();

        protected bool isPropertyEdit = true;

        Property property = new Property();

        string propName = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            try
            {

                property = await destinationTestService.GetPropertyByPropid(Id);

                if (property != null && !string.IsNullOrEmpty(property.Name))
                {
                    propName = property.Name + " - " + "Home Team";
                }
                else
                {
                    propName = "Home Team";
                }

                propertyMgt = await propertyService.GetPropertyMgtByPropId(Id);
                  
                if (propertyMgt == null)
                {
                    isPropertyEdit = false;
                    // Initialize new property with defaults
                    propertyMgt = new PropertyMgt
                    {
                        Propid = Id,
                        RevenueGoal = 1, // Default to max rentals
                        HomeQuality = 1, // Default to best quality
                        Relationship = 1, // Default to good relationship
                        OpsWatch = true,
                        YieldWatch = true,
                        LastReviewed = DateTime.Today
                    };
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Error", $"Could not load property: {ex.Message}");
            }
        }

        private async Task Submit(PropertyMgt model)
        {
            try
            {
                var result = await propertyService.CreateUpdaterPopertymgt(model, isPropertyEdit);
                if (result)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Success",
                        Detail = "Data updated successfully!",
                        Duration = 4000 // in milliseconds
                    });
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Error", $"Could not save property: {ex.Message}");
            }
        }

        private void OnCancel()
        {
            NavigationManager.NavigateTo("/properties");
        }

        // Dropdown options
        private List<DropdownOption> revenueGoalOptions = new()
        {
            new() { Value = 1, Text = "1) Max rentals - pricing at our discretion" },
            new() { Value = 2, Text = "2) Max rentals with pricing parameters" },
            new() { Value = 3, Text = "3) Owner sets pricing (0% discount)" },
            new() { Value = 4, Text = "4) Owner VERY strict on pricing" },
            new() { Value = 5, Text = "5) Holidays only (will be deleted)" },
            new() { Value = 8, Text = "8) Long-term/multiple owner bookings" },
            new() { Value = 9, Text = "9) Max rentals - super aggressive" }
        };

        private List<DropdownOption> homeQualityOptions = new()
        {
            new() { Value = 1, Text = "1) Premium - positioned for max rents" },
            new() { Value = 2, Text = "2) Good - needs minor improvements" },
            new() { Value = 3, Text = "3) Average - shouldn't expect max rents" },
            new() { Value = 4, Text = "4) Poor - deferred maintenance" },
            new() { Value = 5, Text = "5) Needs complete remodel" }
        };

        private List<DropdownOption> relationshipOptions = new()
        {
            new() { Value = 1, Text = "1) Excellent - recent communication" },
            new() { Value = 2, Text = "2) Good - no recent issues" },
            new() { Value = 3, Text = "3) Needs improvement" },
            new() { Value = 4, Text = "4) Unhappy with management" },
            new() { Value = 5, Text = "5) May leave soon" }
        };

        private List<DropdownOption> assignedResourceOptions = new()
        {
            new() { Value = 1, Text = "John Smith (Primary)" },
            new() { Value = 2, Text = "Sarah Johnson" },
            new() { Value = 3, Text = "Michael Brown" },
            new() { Value = 4, Text = "Emily Davis" },
            new() { Value = 5, Text = "Unassigned" }
        };

        private List<DropdownOption> similarHomeOptions = new()
        {
            new() { Value = 101, Text = "101 - Beachfront Villa" },
            new() { Value = 205, Text = "205 - Mountain View Cabin" },
            new() { Value = 312, Text = "312 - Downtown Luxury Apartment" },
            new() { Value = 418, Text = "418 - Lakeside Cottage" },
            new() { Value = 522, Text = "522 - Desert Oasis" }
        };

        public class DropdownOption
        {
            public int Value { get; set; }
            public string Text { get; set; } = "";
        }

    }
}