using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    //  Исключение создания файла
    public class FileCreateException : IOException
    {
        public FileCreateException(){}
        public FileCreateException(string message)
            : base(message)
        {}
    }
}