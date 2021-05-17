using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Abstract
{
    public interface ISingleDataResult<SData> : IResult
    {
         SData SingleData { get; }
    }
}
