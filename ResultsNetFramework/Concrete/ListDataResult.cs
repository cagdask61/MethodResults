﻿using ResultsNetFramework.Abstract;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNetFramework.Concrete
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
        public ListDataResult(List<LData> listData, bool state, string[] tags) : base(state, tags)
        {
            ListData = listData;
        }
        public ListDataResult(List<LData> listData, bool state, string message, string[] tags) : base(state, message, tags)
        {
            ListData = listData;
        }

        public List<LData> ListData { get; }

        public int Count { get => ListData.Count; }
    }
}