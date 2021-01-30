using FluentAssertions;
using Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles;
using Xunit;

namespace Sirh3e.Pattern.Pipeline.Test.Pipelines.Converter.Handlers
{
    public class LowercasePipelineHandlerUnitTest
    {
        [Theory]
        [InlineData("a", "a")]
        [InlineData("A", "a")]
        [InlineData("f", "f")]
        [InlineData("F", "f")]
        [InlineData("ff", "ff")]
        [InlineData("fF", "ff")]
        [InlineData("Ff", "ff")]
        [InlineData("FF", "ff")]
        public void LowercasePipelineHandler_Should_Passed(string @string, string lowercaseString)
        {
            var handler = new LowercasePipelineHandler();

            handler.Process(@string).Should().Be(lowercaseString);
        }
    }
}