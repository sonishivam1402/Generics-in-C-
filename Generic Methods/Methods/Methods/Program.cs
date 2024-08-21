

using System.ComponentModel.DataAnnotations;

class Program
{
    static void Swap<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    static public void display<T>(T[] arr)
    {
        Console.WriteLine("Array After Swaping : ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    /*public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4 };
        Swap(numbers, 0, 2); // Swaps 1 and 3
        display(numbers);

        string[] words = { "Shivam", "Jiya", "Pruthuraj" };
        Swap(words, 1, 2); // Swaps "Jiya" and "Pruthuraj"
        display(words);
    }*/

    
}
