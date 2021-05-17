using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class SuccessSingleDataResult<SData> : SingleDataResult<SData>
    {
        public SuccessSingleDataResult(SData singleData) : base(singleData, true)
        {
        }

        public SuccessSingleDataResult(SData singleData, string message) : base(singleData, true, message)
        {
        }

    }
}
