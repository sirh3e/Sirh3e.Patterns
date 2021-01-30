using Sirh3e.Pattern.Pipeline.Abstraction;

namespace Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles
{
    public class UppercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}