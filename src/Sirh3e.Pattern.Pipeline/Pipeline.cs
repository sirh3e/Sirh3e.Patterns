using System;

namespace Sirh3e.Pattern.Pipeline
{
    public abstract class Pipeline<TInput, TOutput> : IPipelineHandler<TInput, TOutput>
    {
        public Func<TInput, TOutput> PipelineHandlers { get; protected init; }

        public TOutput Process(TInput input)
        {
            _ = input ?? throw new ArgumentNullException(nameof(input));
            _ = PipelineHandlers ?? throw new ArgumentNullException(nameof(input));

            return PipelineHandlers(input);
        }
    }
}