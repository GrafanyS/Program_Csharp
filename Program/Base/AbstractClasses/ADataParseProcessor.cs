using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.Interface;

namespace GIT_C.Program.Base.AbstractClasses
{
    public abstract class ADataParseProcessor : IGetInfo, IParseData
    {
        public abstract string getBirthday();
        public abstract string[] getFullName();
        public abstract string[] getInfoToWrite();
        public abstract long getPhoneNumber();
        public abstract string getSex();
        public abstract void parseData(string data);
    }
}