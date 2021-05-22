using System.Collections.Generic;

namespace ContextualExperience.Brokers.OptionApis
{
    public class OptionApiBroker : IOptionApiBroker
    {
        public List<string> GetAllOptions()
        {
            return new List<string>
            {
                "Choice",
                "Choices",
                "Text"
            };
        }
    }
}
