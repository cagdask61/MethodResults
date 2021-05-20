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
        public Result(bool state,string[] tags):this(state)
        {
            Tags = tags;
        }
        public Result(bool state,string message,string[] tags):this(state,message)
        {
            Tags = tags;
        }

        public bool State { get; }

        public string Message { get; }

        public string[] Tags { get; }

        public int TagsLength { get => Tags.Length; }
    }
}
