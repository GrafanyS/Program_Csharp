using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // То же исключение при записи файла
    using GIT_C.Program.Base.Interface;
    public class TheSameFileWritingException : IOException
    {
        public TheSameFileWritingException(string massage)
            : base(massage)
            {}
    }
}