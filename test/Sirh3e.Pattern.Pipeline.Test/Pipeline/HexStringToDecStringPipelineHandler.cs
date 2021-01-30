using System;
using System.Globalization;

namespace Sirh3e.Pattern.Pipeline.Test.Pipeline
{
    public class HexStringToDecStringPipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return UInt64.Parse(input, NumberStyles.HexNumber).ToString();
        }
    }
}