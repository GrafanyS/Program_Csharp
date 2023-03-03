using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    public class ParseDataException : IOException
    {
        public ParseDataException(string message)
            : base(message)
        
        {}
    }
}