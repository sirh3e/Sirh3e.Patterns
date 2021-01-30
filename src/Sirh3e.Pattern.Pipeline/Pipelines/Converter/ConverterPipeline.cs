using Sirh3e.Pattern.Pipeline.Abstraction;
using Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles;

namespace Sirh3e.Pattern.Pipeline.Pipelines.Converter
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
}