﻿namespace HW15_LinqFromUlearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first task:
            Console.WriteLine("First task!");
            foreach (var num in Parsing.ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in Parsing.ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
            //second task:
            Console.WriteLine("Second task!");           
            foreach (var point in Parsing.ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in Parsing.ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);

        }
    }
}
