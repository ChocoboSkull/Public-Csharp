using System;
using QuickSort;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var array = new int[] { 37, 75, 94, 66, 120, 4, 2 };
        var expected = new int[] { 2, 4, 37, 66, 75, 94, 120 };

        Console.WriteLine("Unsorted: ");
        foreach(int i in array)
        {
            Console.Write(i + " ");
        }

        var sortFunction = new Quick();
        var sortedArray = sortFunction.SortArray(array, 0, array.Length - 1);
     
        Console.WriteLine("\nSorted: ");
        foreach(int i in sortedArray)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nSorted = Expected : " + sortedArray.SequenceEqual(expected));
    }
}
