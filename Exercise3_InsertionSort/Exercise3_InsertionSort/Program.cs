using System;

namespace Exercise3_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 82, 15, 2, 54, 77 };

            Console.Write("Array contains values: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();

            InsertSort(array, array.Length);

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void InsertSort(int[] data, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;

                for (int j = i - 1; j >= 0 && ins != 1; )
                {
                    if(item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else
                    {
                        ins = 1;
                    }
                }
            }
        }
    }
}
