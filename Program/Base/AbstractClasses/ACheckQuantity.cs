using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.Interface;

namespace GIT_C.Program.Base.AbstractClasses
{
    public abstract class ACheckQuantity : ICheckQuantity
    {
        public abstract bool checkQuantity(string[] data);
    }
}