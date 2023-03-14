using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Получить исключение данных
    public class GetDataException : IOException
    {
        public GetDataException(IOException message)
        {
            System.Console.WriteLine("Исключение при чтении с консоли: " + message);
        }
        public GetDataException(string message)
            : base(message)
        {}
    }
}