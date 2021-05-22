using System;
using System.Collections.Generic;
using System.Linq;
using ContextualExperience.Models.Views.OptionViews;
using ContextualExperience.Services.Foundations.Options;

namespace ContextualExperience.Services.Views.OptionViews
{
    public class OptionViewService : IOptionViewService
    {
        private readonly IOptionService optionService;

        public OptionViewService(IOptionService optionService) =>
            this.optionService = optionService;

        public IEnumerable<OptionView> RetrieveAllOptionViews()
        {
            List<string> options = this.optionService.RetrieveAllOptions();

            return options.Select(option => new OptionView
            {
                Text = option,
                Value = $"{option}Base"
            });
        }
    }
}
