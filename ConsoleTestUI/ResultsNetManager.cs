using Results.Abstract;
using Results.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestUI
{
    public class ResultsNetManager
    {
        public IListDataResult<string> GetString()
        {
            return new SuccessListDataResult<string>(new List<string>() { "test-1", "test-2" }, message: "test-message", "tag-1", "tag-2");
        }
        public IDataResult<int> GetInt()
        {
            return new SuccessDataResult<int>(1, message:"test-message","tag-1","tag-2");
        }
        public IDataResult<int[]> GetIntAll()
        {
            return new SuccessDataResult<int[]>(new int[] { 1 },message:"test-message","tag-1","tag-2");
        }
        public ISingleDataResult<int> GetByIntId()
        {
            return new SuccessSingleDataResult<int>(1,message:"test-message","tag-1","tag-2");
        }
        public IResult Add()
        {
            return new SuccessResult(message: "test-message","tag-1","tag-2");
        }
    }
}
