using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class SuccessSingleDataResult<SData> : SingleDataResult<SData>
    {
        public SuccessSingleDataResult(SData singleData) : base(singleData, true)
        {
        }
        public SuccessSingleDataResult(SData singleData, string message) : base(singleData, true, message)
        {
        }
        public SuccessSingleDataResult(SData singleData, params string[] tags) : base(singleData, true, tags)
        {
        }
        public SuccessSingleDataResult(SData singleData, string message, params string[] tags) : base(singleData, true, message,tags)
        {
        }

    }
}
