using System;
using System.Text;

namespace Homework7Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add – додавання, Sub – віднімання, Mul – множення, Div – поділ. 

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Write the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the method of operation: +, -, *, / ");
            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Add(number1, number2);
                    break;
                case '-':
                    Sub(number1, number2);
                    break;
                case '*':
                    Mul(number1, number2);
                    break;
                case '/':
                    Div(number1, number2);
                    break;
                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
            Console.ReadLine();
        }

        static void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
        }

        static void Sub(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");
        }

        static void Mul(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {result}");
        }

        static void Div(int number1, int number2)
        {
            if (number2 != 0)
            {
                int result = number1 / number2;
                Console.WriteLine($"{number1} / {number2} = {result}");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 0");
            }
        }
    }
}

