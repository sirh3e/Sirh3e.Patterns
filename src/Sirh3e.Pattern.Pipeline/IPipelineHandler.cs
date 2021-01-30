namespace Sirh3e.Pattern.Pipeline
{
    public interface IPipelineHandler<in TInput, out TOutput>
    {
        public TOutput Process(TInput input);
    }
}