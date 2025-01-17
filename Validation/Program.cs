namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the login: ");
            var login = Console.ReadLine();
            Console.Write("Enter the password: ");
            var password = Console.ReadLine();
            Console.Write("Confirm the password: ");
            var confirmPassword = Console.ReadLine();

            

           var isValidLogAndPass= ValidationLogPass.ValidateLogPass(login, password, confirmPassword);
            if (isValidLogAndPass)
            {
                Console.WriteLine("Verification is successful.");
            }
            else
            {
                Console.WriteLine("Verification is unsuccessful.");
            }



            Console.ReadLine();
        }
    }
}
