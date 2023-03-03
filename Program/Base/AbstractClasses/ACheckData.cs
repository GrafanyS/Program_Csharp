using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.Interface;

namespace GIT_C.Program.Base.AbstractClasses
{
    //  Абстактный класс проверки данных
    public abstract class ACheckData : ICheckElement
    {
        public abstract bool checkElement(string data);
    }
}