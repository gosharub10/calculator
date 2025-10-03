namespace ConsoleApp1;

public static class InputHelper
{
    public static double InputDouble(string msg)
    {
        Console.WriteLine(msg);
        var number = Console.ReadLine();
        while (true)
        {
            if (double.TryParse(number, out var numberInt))
            {
                return numberInt;
            }

            Console.WriteLine("Введите число, не букву!!!");
            number = Console.ReadLine();
        }
    }
    
    public static int InputInt(string msg)
    {
        Console.WriteLine(msg);
        var number = Console.ReadLine();
        while (true)
        {
            if (int.TryParse(number, out var numberInt))
            {
                return numberInt;
            }

            Console.WriteLine("Введите число, не букву!!!");
            number = Console.ReadLine();
        }
    }
}