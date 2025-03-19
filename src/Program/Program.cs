Console.WriteLine(operations.Addition.Add(7, 2));
Console.WriteLine(operations.Substraction.Substract(10, 1));
Console.WriteLine(operations.Multiplication.Multiply(3, 3));
Console.WriteLine(operations.Divide(18, 2));

public class operations
{
    
    // Esta clase implementa la operación division
    public static double Divide(int a, int b)
    {
        return (double)a / b;
        
    }



//Agrego el arte de la multiplicación
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Substraction
{
    // Esta clase implementa operación resta
    public static int Substract(int a, int b)
    {
        return a - b;
        
    }
}
//Agrego suma
public class Addition
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
}

