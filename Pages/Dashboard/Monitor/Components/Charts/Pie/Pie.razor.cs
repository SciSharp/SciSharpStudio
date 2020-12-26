using Microsoft.AspNetCore.Components;

namespace SciSharpStudio.Pages.Dashboard.Monitor
{
    public partial class Pie
    {
        [Parameter]
        public bool? Animate { get; set; }

        [Parameter]
        public int? LineWidth { get; set; }
    }
}