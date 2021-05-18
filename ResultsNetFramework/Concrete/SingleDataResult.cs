using ResultsNetFramework.Abstract;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResultsNetFramework.Concrete
{
    public class SingleDataResult<SData> : Result, ISingleDataResult<SData>
    {
        public SingleDataResult(SData singleData, bool state) : base(state)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string message) : base(state, message)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string[] tags) : base(state, tags)
        {
            SingleData = singleData;
        }
        public SingleDataResult(SData singleData, bool state, string message, string[] tags) : base(state, message, tags)
        {
            SingleData = singleData;
        }

        public SData SingleData { get; }
    }
}
