// Generic base class
public class Container<T>
{
    public T Value { get; set; }

    public Container(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

// Derived class with additional functionality for numeric types
public class NumberContainer<T> : Container<T> where T : struct
{
    public NumberContainer(T value) : base(value) { }

    public void Increment()
    {
        dynamic tempValue = Value;
        Value = (T)(tempValue + 1);
    }
}

class Program
{
    public static void Main(string[] args)
    {

        NumberContainer<int> intContainer = new NumberContainer<int>(10);
        intContainer.Display();    // Outputs: "Value: 10"
        intContainer.Increment();
        intContainer.Display();    // Outputs: "Value: 11"
    }
}