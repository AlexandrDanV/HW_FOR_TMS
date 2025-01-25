namespace StackGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            Console.WriteLine($"The number of elements: {myStack.Count()}");
            Console.WriteLine(new string('*', 50));

            try
            {
                var elementPop = myStack.Pop();

                Console.WriteLine($"Element: {elementPop}. " +
                    $"The number of elements after Pop(): {myStack.Count()}");
                Console.WriteLine(new string('*', 50));

                var elementPeek = myStack.Peek();
                Console.WriteLine($"Element: {elementPeek}. " +
                    $"The number of elements after Peek(): {myStack.Count()}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
