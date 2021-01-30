using FluentAssertions;
using Sirh3e.Pattern.Pipeline.Pipelines.Converter;
using Xunit;

namespace Sirh3e.Pattern.Pipeline.Test.Pipelines.Converter
{
    public class ConverterPipelineUnitTest
    {
        [Theory]
        [InlineData("a", 10)]
        [InlineData("A", 10)]
        [InlineData("f", 15)]
        [InlineData("F", 15)]
        [InlineData("ff", 255)]
        [InlineData("fF", 255)]
        [InlineData("Ff", 255)]
        [InlineData("FF", 255)]
        public void ConverterPipeline_Should_Passed(string input, int result)
        {
            var pipeline = new ConverterPipeline();

            pipeline.Process(input).Should().Be(result);
        }
    }
}