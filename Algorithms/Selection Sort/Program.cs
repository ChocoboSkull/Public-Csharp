using System;
using SelectionSort;
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

        var sortFunction = new Selection();
        sortFunction.IntArray = array;
        var sortedArray = sortFunction.SortArray();
     
        Console.WriteLine("\nSorted: ");
        foreach(int i in sortedArray)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nSorted = Expected : " + sortedArray.SequenceEqual(expected));
    }
}
