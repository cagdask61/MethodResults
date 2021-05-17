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
    }
}
