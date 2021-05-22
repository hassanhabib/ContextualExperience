using System;
using System.Collections.Generic;
using ContextualExperience.Models.Views.OptionViews;
using ContextualExperience.Services.Views.OptionViews;
using ContextualExperience.Views.Bases;
using Microsoft.AspNetCore.Components;

namespace ContextualExperience.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IOptionViewService OptionViewService { get; set; }

        public IEnumerable<OptionView> OptionViews { get; set; }
        public Type SelectedComponent { get; set; }

        protected override void OnInitialized()
        {
            SelectedComponent = typeof(ChoiceBase);
            this.OptionViews = this.OptionViewService.RetrieveAllOptionViews();
        }

        public void SetComponent(ChangeEventArgs changeEventArgs)
        {
            string fullComponentName =
                $"ContextualExperience.Views.Bases.{changeEventArgs.Value}";

            SelectedComponent = Type.GetType(typeName: fullComponentName);
        }
    }
}
