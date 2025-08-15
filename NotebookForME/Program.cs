using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;

//namespace NotebookForME
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.Unicode;

//            Console.WriteLine("Введіть любе число:");
//            string summand = Console.ReadLine();
//            int number = int.Parse(summand);

//            int result = Chislo(number);
//            Console.WriteLine("Result = " + result);
//        }

//        static int Chislo(int n)
//        {
//            if (n == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                return n * Chislo(n - 1);
//            }
//        }


//        static string Function(string name)
//        {
//            Console.OutputEncoding = Encoding.Unicode;

//            if (name == "Fool")
//            {
//                return "Вы ввели некоректное слово";
//            }

//            string sentence = "Hello" + name + "!";
//            return sentence;
//        }

//        static void Main()
//        {
//            string sentence = Function("Denys");
//            Console.WriteLine(sentence);
//        }


//        static void Recursion(int counter)
//        {
//            counter--;

//            Console.WriteLine("First half of numbers: {0}", counter);

//            if (counter != 0)
//                Recursion(counter);

//            Console.WriteLine("Second half of numbers: {0}", counter);

//        }


//        static void Main()
//        {
//            Recursion(7);
//        }


//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.Unicode;

//            int[] numbers = { 1, 7, 9, 3, 5 };//Робимо масив

//            SortArray(numbers);//Визов метода та передача масива методу

//            Console.WriteLine("Відсортований масив:");
//            foreach (int num in numbers)//Цикл проходить по кожному елементу масива 
//            {
//                Console.WriteLine(num + " ");
//            }
//        }
//        static void SortArray(int[] array)
//        {
//            int n = array.Length; //Зберігаємо длину в масива в змінну n

//            for (int i = 0; i < n; i++) //Переміщуємо найбільше число в кінешь
//            {
//                for (int j = 0; j < n - 1 - i; j++)
//                {
//                    if (array[j] > array[j + 1])
//                    {
//                        int my = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = my;
//                    }
//                }
//            }
//        }




//        static void Main()
//        {
//            int[] numbers = { 5, 2, -3, 16, 0, -90 }; //Робимо масив
//            int index; //Індекс числа місце для которого я шукаю
//            int currentNumber; //Поточне число

//            for (int i = 0; i < numbers.Length; i++) //Создаємо цикл фор,создаємо змінну і,масив працює поки не закінчиться,кожну ітерацію збільшуємо на одиницю
//            {
//                index = i; //Зберігаю індекс числа,котре я буду змінювати
//                currentNumber = numbers[i];//Індекс числа місце для которого я шукаю
//                while (index > 0 && currentNumber < numbers[index - 1]) //Цикл while з двома умовами,Коментар Довгий,Деніс розкаже сам)
//                {
//                    numbers[index] = numbers[index - 1]; //Беремо число котре зліва,та ставимо його й поклади його на поточне місце
//                    index--; //Переход на одну позицію зліва
//                }

//                numbers[index] = currentNumber; //Ставимо останне число на його місце
//            }

//            for (int i = 0; i < numbers.Length; i++) //Проходимось по всім елементам масива та виводимо числа на єкран 
//            {
//                Console.WriteLine(numbers[i]);
//            }
//        }


//        static void Main()  //Як написати масив в 50 єлементів,зі зміною умови
//        {
//            int[] array = new int[50];

//            for (int i = 0; i < 10; i++)
//            {
//                array[i] = i * 2;
//            }

//            for (int i = 10; i < array.Length; i++)
//            {
//                array[i] = i * 3;
//            }

//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine(array[i]);
//            }
//        }


//        static void Main()
//        {
//            int[,,] array =
//            {
//                { {1,2,3}, {4,5,6}, {7,8,9} },
//                { {1,2,3}, {4,6,7}, {7,8,9} },
//                { {1,2,3}, {4,5,6}, {7,8,9} }
//            };

//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    for (int k = 0; k < 3; k++)
//                    {
//                        Console.Write("{0}", array[i, j, k]);
//                    }
//                    Console.Write("\n");
//                }
//                Console.Write("\n");
//            }

//            static void Main()
//            {
//                int[][] jagged = new int[3][];

//                jagged[0] = new int[] { 1, 2 };
//                jagged[1] = new int[] { 1, 2, 3, 4, 5 };
//                jagged[2] = new int[] { 1, 2, 3 };

//                for (int i = 0; i < jagged.Length; ++i)
//                {
//                    for (int j = 0; j < jagged[i].Length; ++j)
//                    {
//                        Console.Write("{0}", jagged[i][j]);
//                    }
//                    Console.Write("\n");
//                }


//            }


//            static void Recursion(int counter)
//            {
//                Console.OutputEncoding = Encoding.Unicode;

//                counter--;

//                Console.WriteLine("Первая половина метода: {0}", counter);

//                if (counter != 0)
//                    Recursion(counter);

//                Console.WriteLine("Вторая половина метода: {0}", counter);
//            }
//            static void Main()
//            {
//                Recursion(7);
//            }


//            //static void ShowArray(string name, params int[] array) КЛЮЧЕВОЕ СЛОВО PARAMS
//            {
//                Console.Write(name);

//                for (int i = 0; i < array.Length; i++)
//                {
//                    Console.Write("{0} ", array[i]);
//                }
//            }


//            static void Main()
//            {
//                ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
//            }


//        class Butterfly
//        {
//            public string name;

//            public void Fly()
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    Console.WriteLine("Fly");
//                }
//            }
//        }

//        static void Main()
//        {
//            Butterfly mahaon = new Butterfly();
//            mahaon.name = "Admiral";

//            mahaon.Fly();
//        }








//    }
//}



//Классы.

namespace Classes
{
    // Создаем класс с именем MyClass.
    // В теле класса создаем открытое поле типа string с именем field и метод с именем Method.

    //class MyClass
    //{
    //    private string field = null;

    //    public string Field
    //    {
    //        set { field = value; }
    //        get { return field; }
    //    }
    //}


    //class Program
    //{
    //    static void Main()
    //    {
    //        MyClass instance = new MyClass();

    //        instance.Field = "hello instance";

    //        Console.WriteLine(instance.Field);

    //        while (true)
    //        {
    //            Console.WriteLine("If u want finish program,tap 1");
    //            string input = Console.ReadLine();

    //            if (input == "1")
    //            {
    //                Console.WriteLine("u are finish");
    //                break;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Unknown kommand,try again");
    //                continue;
    //            }

    //        }
    //    }
    //}


    //class Myclass
    //{
    //    private string field = null;

    //    public string Field
    //    {
    //        set { field = value; }
    //        get { return field; }
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Myclass instance = new Myclass();

    //        instance.Field = "SIIIIIIIUUUUUUU";

    //        Console.WriteLine(instance.Field);

    //        while (true)
    //        {
    //            Console.WriteLine("Tap 1 if u want finish");
    //            string input = Console.ReadLine();

    //            if (input == "1")
    //            {
    //                Console.WriteLine("u are finish");
    //                break;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Not correctly,try again");
    //            }
    //        }
    //    }
    //}

    //class Switch
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Napishi");

    //        string number = Console.ReadLine();

    //        switch (number)
    //        {
    //            case "1":
    //                Console.WriteLine("1");
    //                break;
    //            case "2":
    //                Console.WriteLine("2");
    //                break;
    //                default:
    //                Console.WriteLine("hz");
    //                break;
    //        }


    //    }


    //}


    //class Rectangle
    //{
    //    private double side1; //Поля що описують довжину сторін
    //    private double side2;

    //    public Rectangle(double side1, double side2) //Конструктор
    //    {
    //        this.side1 = side1;
    //        this.side2 = side2;
    //    }

    //    private double AreaCalculator() //Метод обчислення прямокутника
    //    {
    //        return side1 * side2;
    //    }

    //    private double PerimeterCalculator() //Метод обчислення прямокутника
    //    {
    //        return 2 * (side1 + side2);
    //    }

    //    public double Area //Властивість
    //    {
    //        get { return AreaCalculator(); }
    //    }
    //    public double Perimeter //Властивість
    //    {
    //        get { return PerimeterCalculator(); }
    //    }


    //}



    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.OutputEncoding = Encoding.Unicode;


    //        Console.WriteLine("Enter the length of the first side:"); //Приймання першоі сторони
    //        double side1 = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Enter the length of the second side:"); //Приймання другоі сторони 
    //        double side2 = Convert.ToDouble(Console.ReadLine());

    //        Rectangle rectangle = new Rectangle(side1, side2); //Створення єкземпляру класу з параметрами конструктора

    //        Console.WriteLine($"\nПлоща прямокутника : {rectangle.Area}");
    //        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

    //        Console.ReadKey();
    //    }
    //}

    //class MyClass
    //{
    //    public void Method()
    //    {
    //        Console.OutputEncoding = Encoding.Unicode;

    //        Console.WriteLine("Вызван метод класса MyClass");
    //    }
    //}

    //class MyClass2
    //{
    //    // На 18 строке создаем метод с именем CallMethod, который принимает один аргумент типа MyClass и ничего не возвращает
    //    public void CallMethod(MyClass my)
    //    {
    //        // В теле метода CallMethod, на 21 строке вызываем метод с именем Method аргумента my 
    //        my.Method();
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        MyClass my = new MyClass();

    //        MyClass2 my2 = new MyClass2();

    //        my2.CallMethod(my);

    //        // Задержка
    //        Console.ReadKey();
    //    }
    //}


    //class Robot
    //{
    //    private string robotvoice = "im megatron";

    //    public void SayHi()
    //    {
    //        Console.WriteLine("Hi.Im robot");
    //    }

    //    public void SaySecret()
    //    {
    //        Console.WriteLine($"I have secret.{robotvoice}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Robot robot = new Robot();

    //        robot.SayHi();

    //        ////robot.SaySecret();
    //    }
    //}



    //class Address
    //{
    //    private string index;
    //    private string country;
    //    private string city;
    //    private string street;
    //    private string house;
    //    private string apartment;

    //    public string Index
    //    {
    //        get { return index; }
    //        set { index = value; }

    //    }
    //    public string Country
    //    {
    //        get { return country; }
    //        set { country = value; }
    //    }
    //    public string City
    //    {
    //        get { return city; }
    //        set { city = value; }
    //    }
    //    public string Street
    //    {
    //        get { return street; }
    //        set { street = value; }
    //    }
    //    public string House
    //    {
    //        get { return house; }
    //        set { house = value; }
    //    }
    //    public string Apartment
    //    {
    //        get { return apartment; }
    //        set { apartment = value; }
    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Address address = new Address();

    //        address.Index = "2000";
    //        address.Country = "Denmark";
    //        address.City = "Frederiksberg";
    //        address.Street = "Street Danish";
    //        address.House = "House no 5";
    //        address.Apartment = "22";

    //        Console.WriteLine(address.Index);
    //        Console.WriteLine(address.Country);
    //        Console.WriteLine(address.City);
    //        Console.WriteLine(address.Street);
    //        Console.WriteLine(address.House);
    //        Console.WriteLine(address.Apartment);

    //        Console.ReadKey();
    //    }
    //}


    //partial class PartialClass
    //{
    //    partial void PartialMethod();

    //    partial void MyMethod();
    //}

    //partial class PartialClass
    //{
    //    partial void PartialMethod()
    //    {
    //        Console.WriteLine("Called partial method PartialMethod");
    //    }
    //    public void CallPartialMethod()
    //    {
    //        PartialMethod();

    //        MyMethod();
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        PartialClass instance = new PartialClass();

    //        instance.CallPartialMethod();
    //    }
    //}

   //class MyClass //Encapsuulation
   // {
   //     MyClass my = null;

   //     private void Method()
   //     {
   //         Console.WriteLine("HIIIIll");
   //     }

   //     public void CallMethod()
   //     {
   //         my = new MyClass();

   //         my.Method();
   //     }
   // }

   // class Program
   // {
   //     static void Main(string[] args)
   //     {
   //         MyClass my = new MyClass();

   //         my.CallMethod();
   //     }
   // }
}








