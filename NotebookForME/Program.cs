using System;
using System.Linq;
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


        //static void Main()
        //{
        //    Console.OutputEncoding = Encoding.Unicode;

        //    int[] numbers = { 1, 7, 9, 3, 5 };//Робимо масив

        //    SortArray(numbers);//Визов метода та передача масива методу

        //    Console.WriteLine("Відсортований масив:");
        //    foreach (int num in numbers)//Цикл проходить по кожному елементу масива 
        //    {
        //        Console.WriteLine(num + " ");
        //    }
        //}
        //static void SortArray(int[] array)
        //{
        //    int n = array.Length; //Зберігаємо длину в масива в змінну n

        //    for (int i = 0; i < n; i++) //Переміщуємо найбільше число в кінешь
        //    {
        //        for (int j = 0; j < n - 1 - i; j++) 
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                int my = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = my;   
        //            }
        //        }
        //    }
        //}




        //static void Main()
        //{
        //    int[] numbers = { 5, 2, -3, 16, 0, -90 }; //Робимо масив
        //    int index; //Індекс числа місце для которого я шукаю
        //    int currentNumber; //Поточне число

        //    for (int i = 0; i < numbers.Length; i++) //Создаємо цикл фор,создаємо змінну і,масив працює поки не закінчиться,кожну ітерацію збільшуємо на одиницю
        //    {
        //        index = i; //Зберігаю індекс числа,котре я буду змінювати
        //        currentNumber = numbers[i];//Індекс числа місце для которого я шукаю
        //        while (index > 0 && currentNumber < numbers[index - 1]) //Цикл while з двома умовами,Коментар Довгий,Деніс розкаже сам)
        //        {
        //            numbers[index] = numbers[index - 1]; //Беремо число котре зліва,та ставимо його й поклади його на поточне місце
        //            index--; //Переход на одну позицію зліва
        //        }

        //        numbers[index] = currentNumber; //Ставимо останне число на його місце
        //    }

        //    for (int i = 0; i < numbers.Length; i++) //Проходимось по всім елементам масива та виводимо числа на єкран 
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

       static void Main()
        {
            int[] numbers = { 9,8,7,6,5,4,3,2 };
            int index;
            int currentnumber;

            for (int i = 0; i < numbers.Length; i++)
            {
                index = i;
                currentnumber = numbers[i];
                while (index > 0 && currentnumber < numbers[index - 1])
                {
                    numbers[index] = numbers[index - 1];
                    index--;
                }

                numbers[index] = currentnumber;
            }

            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
      
        


        }
        
    }




