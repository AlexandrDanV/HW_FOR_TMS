using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_AnimalAbs
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            StatusDog.SetEat($"The dog is eating!");
        }
    }
}
