using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIT_C.Program.Base.Interface;

namespace GIT_C.Program.Base.AbstractClasses
{
    // Абстактный класс проверки процесса обработки данных
    public abstract class ACheckDataProcessor : ICheckFullName, ICheckQuantity, ICheckBirthday, ICheckSex
    {
        public abstract bool checkFullName(string[] fullName);
        public abstract bool checkQuantity(string[] data);
        public abstract bool checkBirthday(string birthday);
        public abstract bool checkSex(string sex);
    }
}