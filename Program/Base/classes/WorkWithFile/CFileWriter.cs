using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.classes.WorkWithFile
{
    public class CFileWriter
    {
        /// <summary>
        /// Writes  the contents of a file to the specified file
        /// Записывает содержимое файла в указанный файл
        /// </summary>
        /// <param name="CFileWriter"> Записывает содержимое файла в указанный файл </param>
        /// <return></return>

        private CFileCreator cFileCreator{ get; set; }
        private CFindTheSameFileName cFindTheSameFileName{ get; set; }
        private string infoPathFolder{ get; set; }

        public CFileWriter(CFileCreator cFileCreator, CFindTheSameFileName cFindTheSameFileName, string infoPathFolder)
        {
            this.cFileCreator = cFileCreator;
            this.cFindTheSameFileName = cFindTheSameFileName;
            this.infoPathFolder = infoPathFolder;
        }
    }
}