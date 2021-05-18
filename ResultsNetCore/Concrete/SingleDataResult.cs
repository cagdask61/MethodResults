using ResultsNetCore.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ResultsNetCore.Concrete
{
    public class SingleDataResult<SData> : Result, ISingleDataResult<SData>
    {
        public SingleDataResult(SData singleData, bool state) : base(state)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string message) : base(state, message)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string[] tags) : base(state, tags)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string message, string[] tags) : base(state, message, tags)
        {
            SingleData = singleData;
        }

        public SData SingleData { get; }
    }
}
