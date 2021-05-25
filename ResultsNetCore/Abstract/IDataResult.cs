using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNetCore.Abstract
{
    public interface IDataResult<out D> : IResult
    {
        D Data { get; }
    }
}
