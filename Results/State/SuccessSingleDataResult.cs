using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class SuccessSingleDataResult<SData> : SingleDataResult<SData>
    {
        public SuccessSingleDataResult():base(default,true)
        {
        }
        public SuccessSingleDataResult(string message) : base(default, true,message)
        {
        }
        public SuccessSingleDataResult(params string[] tags) : base(default, true,tags)
        {
        }
        public SuccessSingleDataResult(string message,params string[] tags) : base(default, true,message,tags)
        {
        }
        public SuccessSingleDataResult(SData singleData) : base(singleData, true)
        {
        }
        public SuccessSingleDataResult(SData singleData, string message) : base(singleData, true, message)
        {
        }
        public SuccessSingleDataResult(SData singleData,params string[] tags) : base(singleData, true, tags)
        {
        }
        public SuccessSingleDataResult(SData singleData, string message,params string[] tags) : base(singleData, true, message,tags)
        {
        }

    }
}
