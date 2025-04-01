using System;

namespace Switch_Constructions
{
    internal class Program
    {
        static int[] AroundTheArrey(int[] arrey)
        {
            int[] array = new int[arrey.Length]; //Створення нового масиву
            for (int i = 0; i < arrey.Length; i++)
            {
                array[i] = arrey[array.Length - 1 - i];//Записав числа в зворототньому напрямку
            }
            return array; //Повертаємо масив 
        }
        

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4 ,5 };
            int[] arraynumbers = AroundTheArrey (numbers);   
            
             Console.WriteLine (string.Join(" ", arraynumbers));
        }
    }
}
