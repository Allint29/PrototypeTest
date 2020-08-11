using System;
using System.Collections.Generic;
using System.Text;
using TestPrototypePattern.Interfaces;

namespace TestPrototypePattern.Models
{
    public class BigDog : WolfKindAnimals, IMyClonable
    {
        private string _name;

        public string Name => _name;

        public BigDog(int countLegth, int age, string name) : base(countLegth, age)
        {
            this._name = name;
        }

        public override object CopyThisObject()
        {
            return new BigDog(this.CountLegth, this.Age, this.Name);
        }
    }
}
