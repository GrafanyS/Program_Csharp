using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Исключение формата дня рождения exception
    public class BirthdayFormatException : FormatException
    {
        public BirthdayFormatException(){}
        public BirthdayFormatException(string message)
            : base(message)
        {}
    }
}