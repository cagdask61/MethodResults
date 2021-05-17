using Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool state)
        {
            State = state;
        }
        public Result(bool state, string message):this(state)
        {
            Message = message;
        }

        public bool State { get; }

        public string Message { get; }
    }
}
