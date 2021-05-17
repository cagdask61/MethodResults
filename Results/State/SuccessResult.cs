﻿using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }
        public SuccessResult(string message) : base(true, message)
        {
        }


    }
}
