using ResultsNetCore.Abstract;
using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace ResultsNetCore.Concrete
{
    public class ListDataResult<LData> : Result, IListDataResult<LData>
    {
        public ListDataResult(List<LData> listData, bool state) : base(state)
        {
            ListData = listData;
        }
        public ListDataResult(List<LData> listData, bool state, string message) : base(state, message)
        {
            ListData = listData;
        }
        public ListDataResult(List<LData> listData, bool state,params string[] tags) : base(state, tags)
        {
            ListData = listData;
        }
        public ListDataResult(List<LData> listData, bool state, string message,params string[] tags) : base(state, message, tags)
        {
            ListData = listData;
        }

        public List<LData> ListData { get; }

        public int Count { get => ListData.Count; }

        public LData[] ArrayData { get=>ListData.ToArray(); }
    }
}
