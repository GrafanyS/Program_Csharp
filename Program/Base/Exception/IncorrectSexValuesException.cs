using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Исключение неправильных значений пола
    public class IncorrectSexValuesException : IOException
    {
        public IncorrectSexValuesException(string message)
            : base(message)
        {}
    }
}