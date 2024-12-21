namespace Calculator
{/// <summary>
 /// Прога считает любые вариации с '+','-','*','/','percent of the number- 'p'', записанные в одну строчку
 /// Использование скобок и квадратного корня ПОКА не реализованно!
 /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine($"A mathematical example: (ex: 40*p20+44/8) where 'p' is percent!\n" +
                    $"Start entering:");
                var strIn = Console.ReadLine();
                Console.WriteLine(new string('*', 50));
                CalcClass calculator = new CalcClass(strIn);
                var res = calculator.Calculater();
                Console.WriteLine($"Result: {res}");
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("to continue, click: Enter \n" +
                    "to stop, click: 0 and Enter");
                string number = Console.ReadLine();
                {
                    if (number == "0")
                    {
                        Console.Clear();
                        cont = false;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
