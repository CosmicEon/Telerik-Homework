using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] arrayOfValues = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        LargerThanNeighbours(arrayOfValues);
    }
    static void LargerThanNeighbours(int[] array)
    {
        int counter = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i] > array[i + 1])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

