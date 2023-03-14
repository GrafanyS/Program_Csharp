using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Преобразовать Данные в Целочисленное Исключение
    public class ParseDataToIntegerException : IOException
    {
        public ParseDataToIntegerException(){}
        public ParseDataToIntegerException(string message)
            : base(message)
        {}
    }
}