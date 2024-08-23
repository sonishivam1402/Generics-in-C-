/*class Calculator
{
    public void add(int a, int b)
    {
        Console.WriteLine("Int : "+ a + b);
    }

    public void add(double a, double b)
    {
        Console.WriteLine("Double :" + a + b);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Calculator c = new Calculator();
        c.add(2,5);
        c.add(3.0,4.0);
    }
}*/

///////////////////////////////////////////// Generic Overloading ///////////////////////////


using System.Numerics;

public class Calculator<T> where T : INumber<T>
{
    public T Add(T a, T b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        var intCalc = new Calculator<int>();
        Console.WriteLine(intCalc.Add(10, 20)); 

        var doubleCalc = new Calculator<double>();
        Console.WriteLine(doubleCalc.Add(10.5, 20.3));
    }
}