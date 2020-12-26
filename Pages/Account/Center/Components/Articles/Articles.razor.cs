using System.Collections.Generic;
using SciSharpStudio.Models;
using Microsoft.AspNetCore.Components;

namespace SciSharpStudio.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}