using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Полное имя Содержит исключение из цифр
    public class FullNameContainsDigitException : FormatException
    {
        public FullNameContainsDigitException()
        {
            System.Console.WriteLine("Один или несколько символов в значениях полного имени являются цифрами!!!");
        }
        public FullNameContainsDigitException(string message)
            : base(message)
        {}
    }
}

