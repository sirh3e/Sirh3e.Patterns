using System;
using System.Globalization;
using Sirh3e.Pattern.Pipeline.Abstraction;

namespace Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles
{
    public class HexStringToDecStringPipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return UInt64.Parse(input, NumberStyles.HexNumber).ToString();
        }
    }
}