using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNetCore.Abstract
{
    public interface IResult
    {
        bool State { get; }
        string Message { get; }
        string[] Tags { get; }
        int TagsLength { get; }
    }
}
