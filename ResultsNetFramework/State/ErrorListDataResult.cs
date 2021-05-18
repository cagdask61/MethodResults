﻿using ResultsNetFramework.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNetFramework.State
{
    public class ErrorListDataResult<LData> : ListDataResult<LData>
    {
        public ErrorListDataResult(List<LData> listData) : base(listData, false)
        {
        }
        public ErrorListDataResult(List<LData> listData, string message) : base(listData, false, message)
        {
        }
        public ErrorListDataResult(List<LData> listData, string[] tags) : base(listData, false, tags)
        {
        }
        public ErrorListDataResult(List<LData> listData, string message, string[] tags) : base(listData, false, message, tags)
        {
        }
    }
}