using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_LinqFromUlearn
{
    internal class Parsing
    {
        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines.Where(x => x != "")
                .Select(x => (int.TryParse(x, out var resultInt)) ? resultInt : 0)
                .ToArray();
        }
        public static List<Point> ParsePoints(IEnumerable<string> lines)
        { 

            return lines.Select(x => x.Split(" "))
                        .Select(x => new Point(int.Parse(x[0]), int.Parse(x[1])))
                        .ToList();
        }
        public static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(x => x.Students).ToArray();

        }
    }
}
