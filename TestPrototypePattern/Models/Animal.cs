using System;
using System.Collections.Generic;
using System.Text;
using TestPrototypePattern.Interfaces;

namespace TestPrototypePattern.Models
{
    /// <summary>
    /// Класс животного - может родиться, жить, умереть, иметь потомство
    /// </summary>
    public abstract class Animal : IMyClonable
    {
        /// <summary>
        /// Родился
        /// </summary>
        /// <returns></returns>
        internal abstract string WasBorn();

        /// <summary>
        /// Прожил жизнь
        /// </summary>
        /// <returns></returns>
        internal abstract string Living();

        /// <summary>
        /// Имеет потомство
        /// </summary>
        /// <returns></returns>
        internal abstract string HasOffspring();

        /// <summary>
        /// Умер
        /// </summary>
        /// <returns></returns>
        internal abstract string Dead();

        private int _age;
        public int Age => _age;

        public Animal(int age)
        {
            _age = age;
        }

        public abstract object CopyThisObject();
    }
}
