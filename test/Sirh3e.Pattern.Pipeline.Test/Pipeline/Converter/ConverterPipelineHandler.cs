using System;

namespace Sirh3e.Pattern.Pipeline.Test.Pipeline.Converter
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