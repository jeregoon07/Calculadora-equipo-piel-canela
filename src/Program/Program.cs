public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
}

public class Division
{
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }

        return a / b;
    }
}