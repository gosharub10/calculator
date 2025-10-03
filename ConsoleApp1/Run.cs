using ConsoleApp1.Operations;

namespace ConsoleApp1;

public static class Run
{
    private const int Exit = 5;
    
    public static void Start()
    {
        while (true)
        {
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
            
            var x = InputHelper.InputDouble("Введите первое число: ");
            var y = InputHelper.InputDouble("Введите второе число: ");

            OperationExecuter.Execute(operations, x, y);

            Console.WriteLine("Нажмите Enter для продолжения ...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}