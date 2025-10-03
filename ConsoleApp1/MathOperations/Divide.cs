namespace ConsoleApp1.MathOperations;

public static class Divide
{
    public static double Execute(double x, double y) => y == 0 ? throw new DivideByZeroException() : x / y;
}