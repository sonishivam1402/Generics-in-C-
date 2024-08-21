class Program
{
    public static void Main()
    {
        // Swapping integers
        var swappedInts = Swap(1, 2);
        Console.WriteLine($"Swapped: {swappedInts.Item1}, {swappedInts.Item2}"); // Outputs: Swapped: 2, 1

        // Swapping strings
        var swappedStrings = Swap("Hello", "World");
        Console.WriteLine($"Swapped: {swappedStrings.Item1}, {swappedStrings.Item2}"); // Outputs: Swapped: World, Hello
    }

    // Generic method
    public static (T, T) Swap<T>(T first, T second)
    {
        return (second, first);
    }
}
