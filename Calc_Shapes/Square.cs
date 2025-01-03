using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Shapes
{
    internal class Square : Shapes
    {
        public double Side { get; set; }
        public Square() { Initialize(); }
        private double GetValues(string name)
        {
            Console.WriteLine($"Enter the {name} length:");
            var isVal = double.TryParse(Console.ReadLine(), out double cath);
            if (Valid(cath, isVal)) { return cath; }
            else { return -1; }
        }
        private void Initialize()
        {
            var ValA = GetValues("side");

            if (ValA > 0)
            {
                Side = ValA;
            }
            else { Console.WriteLine("Clarify the data!"); }
        }
        bool Valid(double cath, bool argBool)
        {
            if (cath > 0 & argBool == true)
            {
                return true;
            }
            else { return false; }
        }

        public override double CulcAreaShape()
        {
            var result = (Side != 0) ? (Side * 2) : -1;
            return result;
        }
    }
}
