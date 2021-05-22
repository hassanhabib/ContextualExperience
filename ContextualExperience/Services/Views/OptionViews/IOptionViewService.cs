using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContextualExperience.Models.Views.OptionViews;

namespace ContextualExperience.Services.Views.OptionViews
{
    public interface IOptionViewService
    {
        IEnumerable<OptionView> RetrieveAllOptionViews();
    }
}
