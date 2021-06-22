using Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Results.State
{
    public class ErrorDataResult<D> : DataResult<D>
    {
        public ErrorDataResult():base(default,false)
        {
        }
        public ErrorDataResult(string message) : base(default, false,message)
        {
        }
        public ErrorDataResult(params string[] tags) : base(default, false,tags)
        {
        }
        public ErrorDataResult(string message,params string[] tags) : base(default, false,message,tags)
        {
        }
        public ErrorDataResult(D data):base(data,false)
        {
        }
        public ErrorDataResult(D data,string message) : base(data, false,message)
        {
        }
        public ErrorDataResult(D data,params string[] tags) : base(data, false,tags)
        {
        }
        public ErrorDataResult(D data, string message, params string[] tags) : base(data, false,message,tags)
        {
        }

    }
}
