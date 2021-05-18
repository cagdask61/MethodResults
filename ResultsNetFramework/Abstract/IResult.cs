using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsNetFramework.Abstract
{
    public interface IResult
    {
        bool State { get; }
        string Message { get; }
        string[] Tags { get; }
    }
}
