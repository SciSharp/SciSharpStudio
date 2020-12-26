using SciSharpStudio.Models;
using Microsoft.AspNetCore.Components;

namespace SciSharpStudio.Pages.Form
{
    public partial class Step1
    {
        private readonly StepFormModel _model = new StepFormModel();

        [CascadingParameter] public StepForm StepForm { get; set; }

        public void OnValidateForm()
        {
            StepForm.Next();
        }
    }
}