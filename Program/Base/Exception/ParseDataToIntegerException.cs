using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Преобразовать Данные в Целочисленное Исключение
    public class ParseDataToIntegerException : IOException
    {
        public ParseDataToIntegerException()
        {
            System.Console.WriteLine("Не удалось преобразовать строку в целое число!: " + Message);
        }
        public ParseDataToIntegerException(string message)
            : base(message)
        {}
    }
}