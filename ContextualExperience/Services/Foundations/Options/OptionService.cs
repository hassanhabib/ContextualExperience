using System.Collections.Generic;
using ContextualExperience.Brokers.OptionApis;

namespace ContextualExperience.Services.Foundations.Options
{
    public class OptionService : IOptionService
    {
        private readonly IOptionApiBroker optionApiBroker;

        public OptionService(IOptionApiBroker optionApiBroker) =>
            this.optionApiBroker = optionApiBroker;

        public List<string> RetrieveAllOptions() =>
            this.optionApiBroker.GetAllOptions();
    }
}
