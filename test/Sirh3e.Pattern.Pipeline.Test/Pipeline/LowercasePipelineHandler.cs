namespace Sirh3e.Pattern.Pipeline.Test.Pipeline
{
    public class LowercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToLower();
        }
    }
}