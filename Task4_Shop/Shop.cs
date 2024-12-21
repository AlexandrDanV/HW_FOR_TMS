using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Shop
{
    internal class Shop
    {
        Random random = new Random();
        string[] nameProducts;
        decimal[] price; // монет
        Count count;

        int possition;
        public Shop(int numberProd)
        {
            nameProducts = new string[numberProd];
            price = new decimal[numberProd];
            count = new Count();

        }
        public int GetArrayLenght { get => nameProducts.Length; }
        public void Add(string product)
        {
            nameProducts[possition] = product;
            price[possition] = random.Next(40, 150);
            possition++;
        }
        public decimal GetCount { get => count.CountUser; }
        public decimal GetPrice(int index) { return price[index]; }
        public string GetNameProducts(int index) { return nameProducts[index]; }
        public void AfterPay(int numberProd)
        {
            int control = 0;
            int index = 0;
            bool abra = false;

            count.CountUser -= price[numberProd - 1];

            string[] prodArray = new string[nameProducts.Length - 1];
            decimal[] praceArray = new decimal[price.Length - 1];

            for (int i = 0; i < nameProducts.Length - 1; i++)
            {
                control++;
                if (numberProd == control)
                {
                    abra = true;
                }
                if (abra == false)
                {
                    prodArray[i] = nameProducts[i];
                    praceArray[i] = price[i];

                }
                if (abra == true)
                {
                    prodArray[i] = nameProducts[i + 1];
                    praceArray[i] = price[i + 1];
                }
            }

            nameProducts = prodArray;
            price = praceArray;

        }
        public void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Вы покинули магазин!");

            Environment.Exit(0);
        }
        public string PaidProduct(int num)
        {
            return nameProducts[num - 1];
        }
    }
}
