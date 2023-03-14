using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.AbstractClasses;
using GIT_C.Program.Base.Exception;

namespace GIT_C.Program.Base.classes.WorkWithFile
{
    public class CFileCreator : AFileCreator
    {
        /// <summary>
        /// Constructor for CFileCreator
        /// Создать новый файл по указанному пути.
        /// </summary>
        /// <param name="path">- путь плюс имя файла и расширение.</param>
        /// <return>- возвращает true в случае удачного создания.</return>


        
        // public virtual bool createFile(string path);

        public override bool createFile(string path)
        {
            throw new FileCreateException("Файл не создан:");
        }
        // public override bool createFile(string path)
        // {
        //     try {
        //         using (FileStream file = File.Create(path))
        //         {

        //         }
        //         }
        //     catch (FileCreateException)
        //     {
        //         throw new FileCreateException("Файл не создан:");                
        //     }
        // }


    }
}