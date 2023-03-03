using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Полное имя Исключение пустого значения
    public class FullNameEmptyValueException : FormatException
    {
        public FullNameEmptyValueException(string message)
            : base(message)
        {}
    }
}