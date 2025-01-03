using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Shapes
{
    internal class Rhomb : Shapes
    {
        public double Diag_A { get; set; }
        public double Diag_B { get; set; }
        public Rhomb() { Initialize(); }

        private double GetValues(string name)
        {
            Console.WriteLine($"Enter the {name}:");
            var isVal = double.TryParse(Console.ReadLine(), out double cath);
            if (Valid(cath, isVal)) { return cath; }
            else { return -1; }
        }
        private void Initialize()
        {
            var ValA = GetValues("diaganul A");
            var ValB = GetValues("diaganul B");
            if (ValA > 0 & ValB > 0)
            {
                Diag_A = ValA;
                Diag_B = ValB;
            }
            else { Console.WriteLine("Clarify the data!"); }
        }

        public override double CulcAreaShape()
        {
            double squRh = (Diag_B > 0 & Diag_B > 0) ? ((Diag_A * Diag_B) / 2) : -1;
            return squRh;
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
