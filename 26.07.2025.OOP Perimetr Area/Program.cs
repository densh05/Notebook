using System;
using System.Text;

namespace _26._07._2025.OOP_Perimetr_Area
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }


    }



    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;


            Console.WriteLine("Enter the length of the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"\nПлоща прямокутника : {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
