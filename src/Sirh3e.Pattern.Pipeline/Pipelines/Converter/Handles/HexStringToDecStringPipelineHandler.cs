using System;
using System.Globalization;
using Sirh3e.Pattern.Pipeline.Abstraction;

namespace Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles
{
    public class HexStringToDecStringPipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));

            return ulong.Parse(input, NumberStyles.HexNumber).ToString();
        }
    }
}