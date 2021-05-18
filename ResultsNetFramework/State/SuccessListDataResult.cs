using ResultsNetFramework.Concrete;
using System.Collections.Generic;

namespace ResultsNetFramework.State
{
    public class SuccessListDataResult<LData> : ListDataResult<LData>
    {
        public SuccessListDataResult(List<LData> listData) : base(listData, true)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message) : base(listData, true, message)
        {
        }
        public SuccessListDataResult(List<LData> listData, string[] tags) : base(listData, true, tags)
        {
        }
        public SuccessListDataResult(List<LData> listData, string message, string[] tags) : base(listData, true, message, tags)
        {
        }
    }
}
