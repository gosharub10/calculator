namespace ConsoleApp1;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. Выйти");

            var choice = InputInt("Ваш выбор: ");

            if (choice == 5)
            {
                return;
            }
            
            var x = InputDouble("Введите первое число: ");
            var y = InputDouble("Введите второе число: ");

            try
            {
                var operation = SelectOperation((OperationType)(choice - 1));
                Console.WriteLine($"Результат: {operation(x, y)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!!!");
            }
            
            Console.ReadKey();
            Console.Clear();
        }
    }

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

    public static double Add(double x, double y) => x + y;
    public static double Subtract(double x, double y) => x - y;
    public static double Multiply(double x, double y) => x * y;
    public static double Divide(double x, double y) => y == 0 ? throw new DivideByZeroException() : x / y;

    public enum OperationType
    {
        Add,        
        Subtract,   
        Multiply,   
        Divide     
    }

    public delegate double Operation(double x, double y);

    public static Operation SelectOperation(OperationType op)
    {
        switch (op)
        {
            case OperationType.Add:
                return Add;
            case OperationType.Subtract:
                return Subtract;
            case OperationType.Multiply:
                return Multiply;
            case OperationType.Divide:
                return Divide;
            default:
                return Add;
        }
    }
}