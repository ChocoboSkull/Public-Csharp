using System;
using BubbleSort;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
        var expected = new int[] { 1, 20, 49, 57, 73, 99, 133};
        
        Console.WriteLine("Unsorted: ");
        foreach(int i in array)
        {
            Console.Write(i + " ");
        }

        var sortFunction = new Bubble();
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
