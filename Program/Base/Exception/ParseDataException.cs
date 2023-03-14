using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Исключение для анализа данных
    public class ParseDataException : IOException
    {
        public ParseDataException()
        {
            System.Console.WriteLine("Исключение в цикле, во время синтаксического анализа: " + Message);
        }
        public ParseDataException(string message)
            : base(message)
        
        {}
    }
}