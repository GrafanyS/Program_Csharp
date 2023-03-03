using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    public class GetDataArrayException : FormatException
    {
        public GetDataArrayException(string message)
            : base(message)
        {}
    }
}