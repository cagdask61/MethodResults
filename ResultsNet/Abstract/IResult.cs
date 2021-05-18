using System;
using System.Collections.Generic;
using System.Text;

namespace ResultsNet.Abstract
{
    public interface IResult
    {
        bool State { get; }
        string Message { get; }
        string[] Tags { get; }
    }
}
