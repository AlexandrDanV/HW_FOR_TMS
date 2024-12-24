namespace Array_Present
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            {
                Console.Write("Введите количество строк массива: ");
                var controlRow = int.TryParse(Console.ReadLine(), out row);
                Console.Write("Введите количество столбцов массива: ");
                var controlWidth = int.TryParse(Console.ReadLine(), out column);
            }

            int[,] twoD_Array = new int[row, column];
            MyArray myArray = new MyArray(twoD_Array);
            //заполняем
            myArray.FillArray();
            Console.WriteLine(new string('*', 50));
            //выводим
            for (int i = 0; i < twoD_Array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_Array.GetLength(1); j++)
                {
                    Console.Write($"{twoD_Array[i, j]} |");
                }
                Console.WriteLine();
            }
            // реверс элементов
            Console.WriteLine(new string('*', 50));
            myArray.ReversELements(twoD_Array);
            for (int i = 0; i < twoD_Array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_Array.GetLength(1); j++)
                {
                    Console.Write($"{twoD_Array[i, j]} |");
                }
                Console.WriteLine();
            }
            //поиск отрицательных
            var numNagative = myArray.GetNegativeNum(twoD_Array);
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Количество отрицательных : {0}", numNagative);
            //поиск положительных
            Console.WriteLine(new string('*', 50));
            var numPositive = myArray.GetPositiveNum(twoD_Array);
            Console.WriteLine("Количество положительных: {0}", numPositive);

            Console.WriteLine(new string('*', 50));
            // сортировка построчно от меньшего к большему
            myArray.SortArrayToUpper(twoD_Array);
            for (int i = 0; i < twoD_Array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_Array.GetLength(1); j++)
                {
                    Console.Write($"{twoD_Array[i, j]} |");
                }
                Console.WriteLine();
            }

            // сортировка построчно от большего к меньшему
            Console.WriteLine(new string('*', 50));
            myArray.SortArrayToLes(twoD_Array);
            for (int i = 0; i < twoD_Array.GetLength(0); i++)
            {
                for (int j = 0; j < twoD_Array.GetLength(1); j++)
                {
                    Console.Write($"{twoD_Array[i, j]} |");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
