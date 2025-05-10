using System;
using System.Text;

namespace NotebookForME  
{
    internal class Program
    {
        //static void Main()
        // {
        //     Console.OutputEncoding = Encoding.Unicode;

        //     Console.WriteLine("Введіть любе число:");
        //     string summand = Console.ReadLine();
        //     int number = int.Parse(summand);

        //     int result = Chislo(number);
        //     Console.WriteLine("Result = " + result );
        // }

        // static int Chislo(int n)
        // {
        //     if(n == 1)
        //     {
        //         return 1;
        //     }
        //     else
        //     {
        //         return n * Chislo(n - 1);
        //     }
        // }


        //static string Function(string name)
        //{
        //    Console.OutputEncoding = Encoding.Unicode;

        //    if (name == "Fool")
        //    {
        //        return "Вы ввели некоректное слово";
        //    }

        //    string sentence = "Hello" + name + "!";
        //    return sentence;
        //}

        //static void Main()
        //{
        //    string sentence = Function("Denys");
        //    Console.WriteLine(sentence);
        //}


        //static void Recursion(int counter)
        //{
        //    counter--;

        //    Console.WriteLine("First half of numbers: {0}", counter);

        //    if(counter!= 0)
        //        Recursion(counter);

        //      Console.WriteLine("Second half of numbers: {0}" ,counter);

        //}


        //static void Main()
        //{
        //    Recursion(7);
        //}


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
            int n = array.Length; //Зберігаємо длину в масива в змінну n

            for(int i = 0;i < n; i++) 
            {
                for (int j = 0;j < n - 1 - i; j++) //Переміщуємо найбільше число в кінешь
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

