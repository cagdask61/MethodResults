using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNet.State
{
    public class SuccessDataResult<D> : DataResult<D>
    {
        public SuccessDataResult() : base(default, true)
        {
        }
        public SuccessDataResult(string message) : base(default, true, message)
        {
        }
        public SuccessDataResult(params string[] tags) : base(default, true, tags)
        {
        }
        public SuccessDataResult(string message, params string[] tags) : base(default, true, message, tags)
        {
        }
        public SuccessDataResult(D data) : base(data, true)
        {
        }
        public SuccessDataResult(D data, string message) : base(data, true, message)
        {
        }
        public SuccessDataResult(D data, params string[] tags) : base(data, true, tags)
        {
        }
        public SuccessDataResult(D data, string message, params string[] tags) : base(data, true, message, tags)
        {
        }

    }
}
