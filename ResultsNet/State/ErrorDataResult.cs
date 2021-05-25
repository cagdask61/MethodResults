using ResultsNet.Concrete;
using System;

namespace ResultsNet.State
{
    public class ErrorDataResult<D> : DataResult<D>
    {

        public ErrorDataResult(D data) : base(data, false)
        {
        }
        public ErrorDataResult(D data, string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(D data, params string[] tags) : base(data, false, tags)
        {
        }
        public ErrorDataResult(D data, string message, params string[] tags) : base(data, false, message, tags)
        {
        }

    }
}
