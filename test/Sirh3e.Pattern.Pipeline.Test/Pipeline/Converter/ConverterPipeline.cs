namespace Sirh3e.Pattern.Pipeline.Test.Pipeline.Converter
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