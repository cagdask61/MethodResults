using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Abstract
{
    public interface IDataResult<out D> : IResult
    {
        D Data { get; }
    }
}
