using Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Concrete
{
    public class ListDataResult<LData> : Result , IListDataResult<LData>
    {
        public ListDataResult(List<LData> listData, bool state):base(state)
        {
            ListData = listData;
        }
        public ListDataResult(List<LData> listData,bool state, string message):base(state,message)
        {
            ListData = listData;
        }


        public List<LData> ListData { get; }

        public int Count { get=>ListData.Count; }

    }
}
