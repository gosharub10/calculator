using ConsoleApp1.Operations;

namespace ConsoleApp1;

public static class Run
{
    private const int Exit = 5;
    
    public static void Start()
    {
        while (true)
        {
            var x = InputHelper.InputDouble("Введите первое число: ");
            
            OperationMenu.ShowMenu();

            var choice = InputHelper.InputInt("Ваш выбор: ");

            if (choice == Exit)
            {
                return;
            }

            if (!OperationMenu.TryGetOperations(choice, out var operations))
            {
                Console.WriteLine("Такой операции нету!!!");
                Console.ReadKey();
                continue;
            }
            
            var y = InputHelper.InputDouble("Введите второе число: ");

            MathOperation.Execute(operations, x, y);

            Console.WriteLine("Нажмите Enter для продолжения ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}