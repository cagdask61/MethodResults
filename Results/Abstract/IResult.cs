using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Abstract
{
    public interface IResult
    {
        bool State { get; }
        string Message { get; }
        string[] Tags { get; }
        
    }
}
