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

            try
            {
                var isValid = ValidationLogPass.ValidateLogPass(login, password, confirmPassword);
                if (isValid)
                    Console.WriteLine("Login and password verification was successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
