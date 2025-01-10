using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_AnimalAbs
{
    internal abstract class Animal
    {
        public string Name { get; private set; }

        public void SetName(string name)=>Name= name;
        
        public string GetName()=> Name;

        public abstract void Eat();

    }

}
