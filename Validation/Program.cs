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

            Exception ex = null;
            bool isValid = false;
            try
            {
                (isValid, ex) = ValidationLogPass.ValidateLogPass(login, password, confirmPassword);
                if (isValid)
                {
                    Console.WriteLine("Login and password verification was successful.");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
