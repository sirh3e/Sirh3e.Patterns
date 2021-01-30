using FluentAssertions;
using Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles;
using Xunit;

namespace Sirh3e.Pattern.Pipeline.Test.Pipelines.Converter.Handlers
{
    public class UppercasePipelineHandlerUnitTest
    {
        [Theory]
        [InlineData("a", "A")]
        [InlineData("A", "A")]
        [InlineData("f", "F")]
        [InlineData("F", "F")]
        [InlineData("ff", "FF")]
        [InlineData("fF", "FF")]
        [InlineData("Ff", "FF")]
        [InlineData("FF", "FF")]
        public void UppercasePipelineHandler_Should_Passed(string @string, string uppercaseString)
        {
            var handler = new UppercasePipelineHandler();

            handler.Process(@string).Should().Be(uppercaseString);
        }
    }
}