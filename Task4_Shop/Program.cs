namespace Task4_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count count = new Count();
            int theNumberOfProducts = 3;
            Shop shop = new Shop(theNumberOfProducts);
            bool loob = true;
            {
                shop.Add("Яблоко");
                shop.Add("Хлеб");
                shop.Add("Сыр");
            }

            Console.WriteLine($"Добро пожаловать в магазин. У Вас на счете:" +
                $" {shop.GetCount} монет.\n");

            while (loob)
            {
                Console.WriteLine("\nТовары в наличии:");
                for (int i = 0; i < shop.GetArrayLenght; i++)
                {
                    Console.WriteLine($"{i + 1}.{shop.GetNameProducts(i)} - {shop.GetPrice(i)} монет.");
                }
                Console.Write("\n Введите номер товара для покупки или \"0\" для выхода: ");
                int productNum = Convert.ToInt32(Console.ReadLine());
                if (productNum == 0)
                {
                    loob = false;
                    break;
                }
                Console.WriteLine($"Вы купили {shop.PaidProduct(productNum)}");
                shop.AfterPay(productNum);
                Console.WriteLine($"Остаток на счете: {shop.GetCount}");
                if (shop.GetArrayLenght == 0)
                {
                    Console.WriteLine("Товар закончился!");
                    Console.WriteLine("Хотите покинуть магазин нажмите ENter!");
                    Console.ReadLine();
                    loob = false;
                    break;
                }
            }

            shop.ExitProgram();

            Console.ReadLine();

        }
    }
}
