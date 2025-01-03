using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Shapes
{
    internal class Triangle : Shapes
    {
        public double Cath_A { get; set; }
        public double Cath_B { get; set; }
        public double Sinus { get; set; }

        public Triangle()
        {
            Initialize();
        }

        private double GetValues(string name)
        {
            Console.WriteLine($"Enter the {name}:");
            var isVal = double.TryParse(Console.ReadLine(), out double cath);
            if (Valid(cath, isVal)) { return cath; }
            else { return -1; }
        }

        private void Initialize()
        {

            var ValA = GetValues("cath A");
            var ValB = GetValues("cath B");
            var sin = GetValues("sinus");

            if (ValA > 0 & ValB > 0 & sin > 0)
            {
                Cath_A = ValA;
                Cath_B = ValB;
                double angle = Math.PI * sin / 180;
                Sinus = Math.Sin(angle);
            }
            else { Console.WriteLine("Clarify the data!"); }
        }

        public override double CulcAreaShape()
        {
            var result = (Cath_A != 0 & Cath_B != 0) ? 0.5 * Cath_A * Cath_B * Sinus : -1;
            return result;

        }
        bool Valid(double cath, bool argBool)
        {
            if (cath > 0 & argBool == true)
            {
                return true;
            }
            else { return false; }
        }


    }
}
