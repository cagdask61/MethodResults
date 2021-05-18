using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.Abstract
{
    public interface IListDataResult<LData> : IResult
    {
        List<LData> ListData { get; }
        int Count { get; }
    }
}
