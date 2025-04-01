using System;

public class Printer 
{
    private string _brand;
    private int _pagesPrinted;

    public static string Type { get; private set; } 

    public string Model { get; set; } //у Властивості є get set

    public int PagesPrinted
    {
        set { _pagesPrinted = value; }
    }

    static Printer()
    {
        Type = "Laser Printer";
    }

    public Printer()
    {
        _brand = "Unknown";
        _pagesPrinted = 0;
        Model = "Generic Model";
    }

    public Printer(string brand, string model) // Параметри brand and model,параметризований констируктор
    {
        _brand = brand;
        Model = model;
        _pagesPrinted = 0;
    }

    public void PrintMessage(string message) 
    {
        Console.WriteLine($"{_brand} {Model}: {message}");
        _pagesPrinted++;
    }

    public void CheckPrinterStatus()
    {
        if (_pagesPrinted == 0)
        {
            Console.WriteLine("Printer has not printed any pages yet.");
        }
        else if (_pagesPrinted < 10)
        {
            Console.WriteLine("Printer is lightly used.");
        }
        else
        {
            Console.WriteLine("Printer has printed many pages.");
        }
    }

    public void PrintMode(int mode) //Приймає числовий параметр in
    {
        switch (mode)
        {
            case 1:
                Console.WriteLine("Printing in Draft mode.");
                break;
            case 2:
                Console.WriteLine("Printing in Normal mode.");
                break;
            case 3:
                Console.WriteLine("Printing in High Quality mode.");
                break;
            default:
                Console.WriteLine("Invalid print mode.");
                break;
        }
    }

    public void PrintMultipleTimes(string message, int times) //Приймає строкову та чисоловий0
    {
        for (int i = 0; i < times; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Reached the limit of 5 prints, breaking out of loop.");
                break;
            }
            PrintMessage(message + $" ({i + 1})");
        }
    }

    public void DetectPaperJam()
    {
        Random rand = new Random();
        bool[] jamAttempts = new bool[5];

        for (int i = 0; i < jamAttempts.Length; i++)
        {
            jamAttempts[i] = rand.Next(0, 10) == 0;
        }

        for (int i = 0; i < jamAttempts.Length; i++)
        {
            if (jamAttempts[i])
            {
                Console.WriteLine($"Attempt {i + 1}: Paper jam detected! Please clear the jam.");
                return;
            }
            Console.WriteLine($"Attempt {i + 1}: No paper jam detected. Printing continues...");
        }

        Console.WriteLine("Printing completed without any paper jams.");
    }

    public void TrackInkLevel(int totalPages)
    {
        int inkLevel = 100;

        for (int i = 1; i <= totalPages; i++)
        {
            inkLevel -= 2;
            Console.WriteLine($"Printed page {i}. Ink level: {inkLevel}%");

            if (inkLevel <= 20)
            {
                Console.WriteLine("Warning: Ink level is low. Please refill soon.");
                break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printer defaultPrinter = new Printer();
        defaultPrinter.PrintMessage("Hello, World!");
        defaultPrinter.CheckPrinterStatus();

        Printer hpPrinter = new Printer("HP", "LaserJet Pro");
        hpPrinter.PrintMessage("Printing document...");
        hpPrinter.CheckPrinterStatus();

        hpPrinter.PrintMode(2);

        hpPrinter.PrintMultipleTimes("Batch print", 7);
        hpPrinter.DetectPaperJam();
        hpPrinter.TrackInkLevel(15);

        Console.WriteLine($"Printer Type: {Printer.Type}");
    }
}
