
using ResultsNet.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.State
{
    public class SuccessListDataResult<LData> : ListDataResult<LData>
    {
        public SuccessListDataResult() : base(default, true)
        {
        }
        public SuccessListDataResult(string message) : base(default, true, message)
        {
        }
        public SuccessListDataResult(params string[] tags) : base(default, true, tags)
        {
        }
        public SuccessListDataResult(string message, params string[] tags) : base(default, true, message, tags)
        {
        }
        public SuccessListDataResult(List<LData> listData) : base(listData, true)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message) : base(listData, true, message)
        {
        }
        public SuccessListDataResult(List<LData> listData, params string[] tags) : base(listData, true, tags)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message, params string[] tags) : base(listData, true, message, tags)
        {
        }
    }
}
