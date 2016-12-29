using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] arrayOfValues = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int searchedElement = int.Parse(Console.ReadLine());

        NumberCounterInArray(arrayOfValues, searchedElement);
    }
    static void NumberCounterInArray(int[] array, int element)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

