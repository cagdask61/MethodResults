using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNetFramework.Abstract
{
    public interface IListDataResult<LData> : IResult
    {
        List<LData> ListData { get; }
        int Count { get; }
    }
}
