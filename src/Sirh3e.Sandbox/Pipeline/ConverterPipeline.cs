using System;
using System.Globalization;
using Sirh3e.Pattern.Pipeline;

namespace Sirh3e.Sandbox.Pipeline
{
    public class ConverterPipeline : Pipeline<string, int>
    {
        public ConverterPipeline()
        {
            PipelineHandlers = input => input
                .AddHandler(new UppercasePipelineHandler())
                .AddHandler(new LowercasePipelineHandler())
                .AddHandler(new HexStringToDecStringPipelineHandler())
                .AddHandler(new ConverterPipelineHandler());
        }
    }

    public class HexStringToDecStringPipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return UInt64.Parse(input, NumberStyles.HexNumber).ToString();
        }
    }

    public class UppercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }

    public class LowercasePipelineHandler : IPipelineHandler<string, string>
    {
        public string Process(string input)
        {
            return input.ToLower();
        }
    }
}