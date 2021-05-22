using System.Collections.Generic;

namespace ContextualExperience.Brokers.OptionApis
{
    public interface IOptionApiBroker
    {
        List<string> GetAllOptions();
    }
}
