using ResultsNetFramework.Concrete;

namespace ResultsNetFramework.State
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }
        public ErrorResult(string message) : base(false, message)
        {
        }
        public ErrorResult(string[] tags) : base(false, tags)
        {
        }
        public ErrorResult(string message, string[] tags) : base(false, message, tags)
        {
        }

    }
}
