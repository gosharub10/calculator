using ConsoleApp1.MathOperations;

namespace ConsoleApp1.Operations;

public static class OperationSelect
{
    public static OperationDelegate SelectOperation(OperationType op)
    {
        switch (op)
        {
            case OperationType.Add:
                return Add.Execute;
            case OperationType.Subtract:
                return Subtract.Execute;
            case OperationType.Multiply:
                return Multiply.Execute;
            case OperationType.Divide:
                return Divide.Execute;
            default:
                return Add.Execute;
        }
    }
}