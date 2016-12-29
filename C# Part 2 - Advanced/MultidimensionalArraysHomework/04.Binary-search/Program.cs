using System;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        string inputArray = Console.ReadLine();//if the array is string of values separated by space
        int[] splitedArray = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int searchedElement = int.Parse(Console.ReadLine());

        int positionInArray = Array.BinarySearch(splitedArray, searchedElement);

        Console.WriteLine("Element {0} is on Index {1}", searchedElement, positionInArray);
    }
}
