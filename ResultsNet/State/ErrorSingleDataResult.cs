using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class ErrorSingleDataResult<SData> : SingleDataResult<SData>
    {
        public ErrorSingleDataResult(SData singleData) : base(singleData, false)
        {
        }
        public ErrorSingleDataResult(SData singleData, string message) : base(singleData, false, message)
        {
        }
        public ErrorSingleDataResult(SData singleData, string[] tags) : base(singleData, false, tags)
        {
        }
        public ErrorSingleDataResult(SData singleData, string message, string[] tags) : base(singleData, false, message, tags)
        {
        }
    }
}
