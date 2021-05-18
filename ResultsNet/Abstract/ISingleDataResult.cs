using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.Abstract
{
    public interface ISingleDataResult<SData> : IResult
    {
         SData SingleData { get; }
    }
}
