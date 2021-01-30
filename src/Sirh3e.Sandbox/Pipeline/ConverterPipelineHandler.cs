using System;
using Sirh3e.Pattern.Pipeline;

namespace Sirh3e.Sandbox.Pipeline
{
    public class ConverterPipelineHandler : IPipelineHandler<string, int>
    {
        public int Process(string input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));

            return Convert.ToInt32(input);
        }
    }
}