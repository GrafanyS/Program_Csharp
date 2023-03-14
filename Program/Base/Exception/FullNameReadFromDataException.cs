using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Полное имя, считанное из исключения данных
    public class FullNameReadFromDataException : FormatException
    {
        public FullNameReadFromDataException(){}
        public FullNameReadFromDataException(string message)
            : base(message)
        {}
    }
}