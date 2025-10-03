namespace ConsoleApp1.Operations;

public static class OperationExecuter
{
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