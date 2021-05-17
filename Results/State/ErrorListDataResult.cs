using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class ErrorListDataResult<LData> : ListDataResult<LData>
    {
        public ErrorListDataResult(List<LData> listData) : base(listData, false)
        {
        }
        public ErrorListDataResult(List<LData> listData, string message) : base(listData, false, message)
        {
        }
    }
}
