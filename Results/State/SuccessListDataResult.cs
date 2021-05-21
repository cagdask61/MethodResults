using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class SuccessListDataResult<LData> : ListDataResult<LData>
    {
        public SuccessListDataResult(List<LData> listData) : base(listData, true)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message) : base(listData, true, message)
        {
        }
        public SuccessListDataResult(List<LData> listData,params string[] tags) : base(listData, true, tags)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message,params string[] tags) : base(listData, true, message, tags)
        {
        }
    }
}
