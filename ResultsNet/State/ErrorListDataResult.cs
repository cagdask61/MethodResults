using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class ErrorListDataResult<LData> : ListDataResult<LData>
    {
        public ErrorListDataResult(List<LData> listData) : base(listData, false)
        {
        }
        public ErrorListDataResult(List<LData> listData, string message) : base(listData, false, message)
        {
        }
        public ErrorListDataResult(List<LData> listData, params string[] tags) : base(listData, false, tags)
        {
        }
        public ErrorListDataResult(List<LData> listData, string message, params string[] tags) : base(listData, false, message, tags)
        {
        }
    }
}
