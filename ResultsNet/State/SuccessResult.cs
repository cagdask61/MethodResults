using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }
        public SuccessResult(string message) : base(true, message)
        {
        }
        public SuccessResult(params string[] tags) : base(true,tags)
        {
        }
        public SuccessResult(string message, params string[] tags) : base(true,message, tags)
        {
        }
    }
}
