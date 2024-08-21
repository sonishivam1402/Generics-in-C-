// Generic Interface
public interface IComparer<T>
{
    int Compare(T x, T y);
}

// Class implementing the generic interface for comparing two Person objects
public class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age); // Compare by Age
    }
}

// Simple Person class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{

    public static void Main(string[] args)
    {
        Person person1 = new Person { Name = "Shivam", Age = 22 };
        Person person2 = new Person { Name = "Jiya", Age = 50 };

        PersonComparer comparer = new PersonComparer();
        int result = comparer.Compare(person1, person2);

        if (result < 0)
        {
            Console.WriteLine($"{person1.Name} is younger than {person2.Name}");
        }
        else if (result > 0)
        {
            Console.WriteLine($"{person1.Name} is older than {person2.Name}");
        }
        else
        {
            Console.WriteLine($"{person1.Name} and {person2.Name} are the same age");
        }
    }
}
