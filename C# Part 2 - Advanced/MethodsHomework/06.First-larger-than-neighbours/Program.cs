using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] arrayOfValues = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        FirstLargerThanNeighbours(arrayOfValues);
    }
    static void FirstLargerThanNeighbours(int[] array)
    {
        int idexNum = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i] > array[i + 1])
            {
                idexNum = i;
                break;
            }
            else if (idexNum == 0)
            {
                idexNum--;
            }
        }
        Console.WriteLine(idexNum);
    }
}

