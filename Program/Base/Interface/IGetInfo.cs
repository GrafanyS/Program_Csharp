using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.Interface
{
    // интерфейс получения информации
    public interface IGetInfo
    {
        public String[] getFullName();
        public String getBirthday();
        public long getPhoneNumber();
        public String getSex();
        public String[] getInfoToWrite();
    }
}