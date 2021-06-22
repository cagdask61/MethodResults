using Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Concrete
{
    public class SingleDataResult<SData> : Result , ISingleDataResult<SData>
    {
        public SingleDataResult(SData singleData, bool state):base(state)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string message) : base(state,message)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state,params string[] tags) : base(state,tags)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state,string message,params string[] tags) : base(state,message,tags)
        {
            SingleData = singleData;
        }

        public SData SingleData { get; }
    }
}
