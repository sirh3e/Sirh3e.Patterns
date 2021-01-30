namespace Sirh3e.Pattern.Pipeline.Test.Pipeline
{
    public class UppercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}