using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_AnimalAbs
{
    internal static class StatusDog
    {
        public static string DogEat { get; private set; }

        public static void SetEat(string eat) => DogEat = eat;
      
        
    }
}
