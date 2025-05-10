using System;
using System.Text;

namespace MassivesCounter
{
    class Program // 
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] numbers = { 1, 7, 9, 3, 5 };

            SortArray(numbers);

            Console.WriteLine("Відсортований масив:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }

        static void SortArray(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int my = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = my;
                    }
                }
            }
        }
    }
}
