using ResultsNet.Abstract;
using ResultsNet.Concrete;
using ResultsNet.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestUI
{
    public class ResultsNetManager
    {

        public IResult Get(string message)
        {
            if (message == null)
            {
                return new ErrorResult("Error");
            }
            return new SuccessResult("Success");
        }
    }
}
