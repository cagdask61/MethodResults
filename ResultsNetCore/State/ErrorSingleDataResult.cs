using ResultsNetCore.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNetCore.State
{
    public class ErrorSingleDataResult<SData> : SingleDataResult<SData>
    {
        public ErrorSingleDataResult() : base(default, false)
        {
        }
        public ErrorSingleDataResult(string message) : base(default, false, message)
        {
        }
        public ErrorSingleDataResult(params string[] tags) : base(default, false, tags)
        {
        }
        public ErrorSingleDataResult(string message, params string[] tags) : base(default, false, message, tags)
        {
        }
        public ErrorSingleDataResult(SData singleData) : base(singleData, false)
        {
        }
        public ErrorSingleDataResult(SData singleData, string message) : base(singleData, false, message)
        {
        }
        public ErrorSingleDataResult(SData singleData, params string[] tags) : base(singleData, false, tags)
        {
        }
        public ErrorSingleDataResult(SData singleData, string message, params string[] tags) : base(singleData, false, message, tags)
        {
        }
    }
}
