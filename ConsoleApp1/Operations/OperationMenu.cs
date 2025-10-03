namespace ConsoleApp1.Operations;

public static class OperationMenu
{
    public static void ShowMenu()
    {
        Console.WriteLine("1. +");
        Console.WriteLine("2. -");
        Console.WriteLine("3. *");
        Console.WriteLine("4. /");
        Console.WriteLine("5. Выйти");
    }

    public static bool TryGetOperations(int choice, out OperationType operationType)
    {
        var operationDictionary = new Dictionary<int, OperationType>
        {
            { 1, OperationType.Add },
            { 2, OperationType.Subtract },
            { 3, OperationType.Multiply },
            { 4, OperationType.Divide }
        };
        
        return operationDictionary.TryGetValue(choice, out operationType);
    }
}