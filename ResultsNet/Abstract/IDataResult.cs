using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNet.Abstract
{
    public interface IDataResult<out D> : IResult
    {
        D Data { get; }
    }
}
