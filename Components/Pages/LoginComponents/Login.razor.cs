using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace Destination.Components.Pages.LoginComponents
{
    public partial class Login
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
        protected CustomAuthStateProvider AuthProvider { get; set; }

        [Inject]
        public destinationTestService destinationTestService { get; set; }

        private string Username { get; set; }
        private string Password { get; set; }
        private bool RememberMe { get; set; }
        private string? ErrorMessage { get; set; }

        private async Task LoginUser()
        {
            var isValidateRole = await destinationTestService.ValidateUserAndGetRole(Username, Password);
            if (isValidateRole != 0)
            {
                await AuthProvider.MarkUserAsAuthenticated(isValidateRole);
                NavigationManager.NavigateTo("/home");
            }
            else
            {
                ErrorMessage = "Invalid email or password.";
            }
        }
    }
}