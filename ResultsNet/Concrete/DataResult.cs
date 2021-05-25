using ResultsNet.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNet.Concrete
{
    public class DataResult<D> : Result, IDataResult<D>
    {
        public DataResult(D data, bool state) : base(state)
        {
            Data = data;
        }
        public DataResult(D data, bool state, string message) : base(state, message)
        {
            Data = data;
        }
        public DataResult(D data, bool state, params string[] tags) : base(state, tags)
        {
            Data = data;
        }
        public DataResult(D data, bool state, string message, params string[] tags) : base(state, message, tags)
        {
            Data = data;
        }

        public D Data { get; }
    }
}
