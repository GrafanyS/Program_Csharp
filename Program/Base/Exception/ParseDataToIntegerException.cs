using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    public class ParseDataToIntegerException : IOException
    {
        public ParseDataToIntegerException(string message)
            : base(message)
        {}
    }
}