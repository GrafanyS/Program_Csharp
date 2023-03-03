using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Exception
{
    // Исключение создания моего файла
    public class MyFileCreateException : IOException
    {
        public MyFileCreateException(string massage)
            : base(massage)
        
        {}
    }
}