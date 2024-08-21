class Calc<T>
{
    public static bool areEquals(T a, T b)
    {
        return a.Equals(b);
    } 
}

class Program
{
    public static void Main(string[] args)
    {
        bool equal = Calc<int>.areEquals(1, 2);
        Console.WriteLine(equal);

        bool equal1 = Calc<string>.areEquals("a", "a");
        Console.WriteLine(equal1);
    }
}    
