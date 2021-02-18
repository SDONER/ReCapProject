using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult :Result
    {
        public SuccessDataResult(string message) :base(true, message)
        {

        }

        public SuccessDataResult() : base(true)
        {

        }
    }
}
