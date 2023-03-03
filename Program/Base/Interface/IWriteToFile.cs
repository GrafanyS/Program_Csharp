using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GIT_C.Program.Base.Interface
{
    // интерфейс записи в файл
    using GIT_C.Program.Base.Exception;
    public interface IWriteToFile
    {
        public Boolean writeToFile(string[] infoToWrite);
    }
}