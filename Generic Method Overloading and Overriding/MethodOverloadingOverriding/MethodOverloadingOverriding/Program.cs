// Generic base class
public class Printer<T>
{
    public virtual void Print(T value)
    {
        Console.WriteLine($"Printing: {value}");
    }
}

// Derived class with method overriding and overloading
public class SpecialPrinter<T> : Printer<T>
{
    // Overriding the Print method
    public override void Print(T value)
    {
        Console.WriteLine($"[Special Print] {value}");
    }

    // Overloading the Print method to accept a prefix
    public void Print(T value, string prefix)
    {
        Console.WriteLine($"{prefix}: {value}");
    }
}

class Program
{

    public static void Main(string[] args)
    {

        Printer<int> printer = new Printer<int>();
        printer.Print(10);  // Outputs: "Printing: 10"

        SpecialPrinter<int> specialPrinter = new SpecialPrinter<int>();
        specialPrinter.Print(20);                    // Outputs: "[Special Print] 20"
        specialPrinter.Print(20, "Value is");  // Outputs: "Value is: 20"
    }
}