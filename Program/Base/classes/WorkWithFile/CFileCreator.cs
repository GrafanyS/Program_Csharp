using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.AbstractClasses;
using GIT_C.Program.Base.Exception;

namespace GIT_C.Program.Base.classes.WorkWithFile
{
    public class CFileCreator : AFileCreator
    {
        private object? file;

        /**
        * Создает новый файл по указанному пути.
        * @param path - путь плюс имя файла и расширение.
        * @return - возвращает true в случае удачного создания.
        */

        
        public virtual bool CreateFile(string path);
        public override bool createFile(string path)
        {
            try {
                using (var file = File.OpenRead(path))
                }
            catch (FileCreateException)
            {
                throw;                
            }
        }
    }
}