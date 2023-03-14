using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Получить исключение массива данных
    public class GetDataArrayException : FormatException
    {
        public GetDataArrayException(){}
        public GetDataArrayException(string message)
            : base(message)
        {}
    }
}