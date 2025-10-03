namespace ConsoleApp1.Operations;

public static class OperationSelect
{
    public static OperationDelegate SelectOperation(OperationType op)
    {
        switch (op)
        {
            case OperationType.Add:
                return MathOperation.Add;
            case OperationType.Subtract:
                return MathOperation.Subtract;
            case OperationType.Multiply:
                return MathOperation.Multiply;
            case OperationType.Divide:
                return MathOperation.Divide;
            default:
                return MathOperation.Add;
        }
    }
}