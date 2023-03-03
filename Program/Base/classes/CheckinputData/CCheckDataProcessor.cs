using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_C.Program.Base.classes.CheckinputData
{
    public class CCheckDataProcessor
    {
        private CCheckQuantity cCheckQuantity;
        private CCheckFullName cCheckFullName;
        private CCheckBirthday cCheckBirthday;
        private CCheckSex cCheckSex;

        public CCheckDataProcessor(CCheckQuantity cCheckQuantity, CCheckFullName cCheckFullName, CCheckBirthday cCheckBirthday, CCheckSex cCheckSex)
        {
            this.cCheckQuantity = cCheckQuantity;
            this.cCheckFullName = cCheckFullName;
            this.cCheckBirthday = cCheckBirthday;
            this.cCheckSex = cCheckSex;
        }
    }
}