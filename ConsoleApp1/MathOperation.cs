using ConsoleApp1.Operations;

namespace ConsoleApp1;

public static class MathOperation
{
    public static double Add(double x, double y) => x + y;
    
    public static double Divide(double x, double y) => y == 0 ? throw new DivideByZeroException() : x / y;
    
    public static double Multiply(double x, double y) => x * y;
    
    public static double Subtract(double x, double y) => x - y;
    
    public static void Execute(OperationType operationType, double x, double y)
    {
        try
        {
            var operation = OperationSelect.SelectOperation(operationType);
            var result = operation(x, y);
            
            Console.WriteLine($"Результат: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}