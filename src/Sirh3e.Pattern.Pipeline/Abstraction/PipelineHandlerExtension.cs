using System;

namespace Sirh3e.Pattern.Pipeline.Abstraction
{
    public static class PipelineHandlerExtension
    {
        public static TOutput AddHandler<TInput, TOutput>(this TInput input, IPipelineHandler<TInput, TOutput> handler)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = handler ?? throw new ArgumentNullException(nameof(input));

            return handler.Process(input);
        }
    }
}