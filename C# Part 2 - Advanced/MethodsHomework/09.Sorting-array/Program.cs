using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputArrayLength = Console.ReadLine();
        int[] twoArraysLength = inputArrayLength.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string inputArray = Console.ReadLine();
        int[] firstArray = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        ArraySort(firstArray);
    }
    static void ArraySort(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine(array[i]);
                break;
            }
            Console.Write("{0} ", array[i]);
        }
    }
}

