using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_LinqFromUlearn
{
    internal class ParsingNumber
    {
        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines.Where(x => x != "")
                .Select(x => (int.TryParse(x, out var resultInt)) ? resultInt : 0)
                .ToArray();
        }
    }
}
