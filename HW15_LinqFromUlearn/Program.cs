namespace HW15_LinqFromUlearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// First task. 
            foreach (var num in ParsingNumber.ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in ParsingNumber.ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
            // Successful


        }
    }
}
