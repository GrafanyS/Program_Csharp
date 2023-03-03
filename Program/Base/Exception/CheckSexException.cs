using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    public class CheckSexException : FormatException
    {
        public CheckSexException(string message)
            : base(message)
        {}
    }
}