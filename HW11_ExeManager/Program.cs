namespace HW11_ExeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var executionManager = new ExecutionManager(2, 3);
            var result = executionManager.Execute(Operations.Sum);
            Console.WriteLine($"Result {result}");
            Console.ReadLine();
        }
    }
}
