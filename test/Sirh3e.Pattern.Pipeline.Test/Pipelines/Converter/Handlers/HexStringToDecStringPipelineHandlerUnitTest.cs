using FluentAssertions;
using Sirh3e.Pattern.Pipeline.Pipelines.Converter.Handles;
using Xunit;

namespace Sirh3e.Pattern.Pipeline.Test.Pipelines.Converter.Handlers
{
    public class HexStringToDecStringPipelineHandlerUnitTest
    {
        [Theory]
        [InlineData("a", "10")]
        [InlineData("A", "10")]
        [InlineData("f", "15")]
        [InlineData("F", "15")]
        [InlineData("ff", "255")]
        [InlineData("fF", "255")]
        [InlineData("Ff", "255")]
        [InlineData("FF", "255")]
        public void HexStringToDecStringPipelineHandler_Should_Passed(string hexString, string decString)
        {
            var handler = new HexStringToDecStringPipelineHandler();

            handler.Process(hexString).Should().Be(decString);
        }
    }
}