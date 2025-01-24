namespace HW11_ExeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var executionManager = new OperationManager(7, 3);
            var result = executionManager.Execute(Operation.Subtract);
            Console.WriteLine($"Result {result}");
            Console.ReadLine();
        }
    }
}
