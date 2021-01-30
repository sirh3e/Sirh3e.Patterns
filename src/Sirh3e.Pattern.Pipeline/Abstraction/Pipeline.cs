using System;

namespace Sirh3e.Pattern.Pipeline.Abstraction
{
    public abstract class Pipeline<TInput, TOutput> : IPipelineHandler<TInput, TOutput>
    {
        public Func<TInput, TOutput> PipelineHandlers { get; protected init; }

        public TOutput Process(TInput input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = PipelineHandlers ?? throw new ArgumentNullException(nameof(PipelineHandlers));

            return PipelineHandlers(input);
        }
    }
}