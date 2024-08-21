using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class Electronics
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class Clothing
{
    public string Size { get; set; }
    public string Color { get; set; }
}



public class ShoppingCart<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine($"{typeof(T).Name} added to cart.");
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
        Console.WriteLine($"{typeof(T).Name} removed from cart.");
    }

    public void DisplayItems()
    {
        Console.WriteLine($"Items in your {typeof(T).Name} cart:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}


public class Program
{
    public static void Main()
    {
        // Create a shopping cart for books
        ShoppingCart<Book> bookCart = new ShoppingCart<Book>();
        bookCart.AddItem(new Book { Title = "C# in Depth", Author = "Jon Skeet" });
        bookCart.DisplayItems();

        // Create a shopping cart for electronics
        ShoppingCart<Electronics> electronicsCart = new ShoppingCart<Electronics>();
        electronicsCart.AddItem(new Electronics { Brand = "Apple", Model = "iPhone 14" });
        electronicsCart.DisplayItems();

        // Create a shopping cart for clothing
        ShoppingCart<Clothing> clothingCart = new ShoppingCart<Clothing>();
        clothingCart.AddItem(new Clothing { Size = "M", Color = "Blue" });
        clothingCart.DisplayItems();
    }
}
