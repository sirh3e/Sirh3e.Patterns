using Sirh3e.Pattern.Pipeline.Abstraction;

namespace Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles
{
    public class LowercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToLower();
        }
    }
}