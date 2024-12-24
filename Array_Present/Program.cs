namespace Array_Present
{
    internal class Program
    {
        static void ToConsol(int[,]array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} |");
                }
                Console.WriteLine();
            }
        }
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
            ToConsol(twoD_Array);
            // реверс элементов
            Console.WriteLine(new string('*', 50));
            myArray.ReversELements(twoD_Array);
            ToConsol(twoD_Array);
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
            ToConsol(twoD_Array);

            // сортировка построчно от большего к меньшему
            Console.WriteLine(new string('*', 50));
            myArray.SortArrayToLes(twoD_Array);
            ToConsol(twoD_Array);



            Console.ReadLine();
        }
    }
}
