using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Present
{
    internal class MyArray
    {
        Random random;
        int[,] twoD_Array;

        public MyArray(int[,] array)
        {
            twoD_Array = array;
            random = new Random();
        }
        public void FillArray()
        {
            int lengthRow = twoD_Array.GetLength(0);
            int lengthColumn = twoD_Array.GetLength(1);
            {
                for (int i = 0; i < lengthRow; i++)
                {
                    for (int j = 0; j < lengthColumn; j++)
                    {
                        twoD_Array[i, j] = random.Next(-99, 99);
                    }
                }
            }
        }
        public int GetNegativeNum(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int GetPositiveNum(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int[,] SortArrayToUpper(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] > array[i, k])
                        {
                            Swap(ref array[i, k], ref array[i, j]);

                        }
                    }



                }
            }
            return array;
        }
        public int[,] SortArrayToLes(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i, k])
                        {
                            Swap(ref array[i, k], ref array[i, j]);
                        }
                    }

                }
            }
            return array;
        }

        public int[,] ReversELements(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int k = 0;
                for (int j = array.GetLength(1) - 1; j >= array.GetLength(1) / 2; j--)
                {

                    var item = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = item;
                    k++;
                }
            }
            return array;
        }
        void Swap(ref int x, ref int y)
        {
            var z = x;
            x = y;
            y = z;
        }
    }
}
