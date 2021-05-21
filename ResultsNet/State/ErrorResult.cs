using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }
        public ErrorResult(string message) : base(false, message)
        {
        }
        public ErrorResult(params string[] tags) : base(false, tags)
        {
        }
        public ErrorResult(string message, params string[] tags) : base(false, message, tags)
        {
        }

    }
}
