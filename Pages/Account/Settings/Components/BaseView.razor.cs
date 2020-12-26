using System.Threading.Tasks;
using SciSharpStudio.Models;
using SciSharpStudio.Services;
using Microsoft.AspNetCore.Components;

namespace SciSharpStudio.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}