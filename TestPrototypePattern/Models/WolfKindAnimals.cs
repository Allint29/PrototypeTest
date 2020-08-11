using System;
using System.Collections.Generic;
using System.Text;
using TestPrototypePattern.Interfaces;

namespace TestPrototypePattern.Models
{
    public class WolfKindAnimals : Animal, IMyClonable
    {
        internal override string Dead()
        {
            return "WolfKindAnimals was dead(";
        }

        internal override string HasOffspring()
        {
            return "WolfKindAnimals Has offspring";
        }

        internal override string Living()
        {
            return "WolfKindAnimals living";
        }

        internal override string WasBorn()
        {
            return "WolfKindAnimals was birn";
        }

        internal virtual string Voice()
        {
            return "Haw-haw";
        }

        private int _countLegth;
        public int CountLegth
        {
            get { return _countLegth; }
            set { _countLegth = value; }
        }

        public WolfKindAnimals(int countLegth, int age) : base(age)
        {
            this._countLegth = countLegth;
        }

        public override object CopyThisObject()
        {
            return new WolfKindAnimals(this._countLegth, this.Age);
        }
    }
}
