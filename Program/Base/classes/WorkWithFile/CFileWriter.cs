using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.classes.WorkWithFile
{
    public class CFileWriter
    {
        private CFileCreator cFileCreator;
        private CFindTheSameFileName cFindTheSameFileName;
        private string infoPathFolder;

        public CFileWriter(CFileCreator cFileCreator, CFindTheSameFileName cFindTheSameFileName, string infoPathFolder)
        {
            this.cFileCreator = cFileCreator;
            this.cFindTheSameFileName = cFindTheSameFileName;
            this.infoPathFolder = infoPathFolder;
        }
    }
}