namespace Sirh3e.Pattern.Pipeline.Abstraction
{
    public interface IPipelineHandler<in TInput, out TOutput>
    {
        public TOutput Process(TInput input);
    }
}