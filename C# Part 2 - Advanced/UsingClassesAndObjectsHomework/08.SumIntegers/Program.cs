using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //read the input string of numbers separated by white spaces 
        string inputData = Console.ReadLine();
        //convert the input by splitng into array,
        //parsing each idex from string to int and remake them to array of ints
        int[] arrayData = inputData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine(SumOfNumbers(arrayData));
    }
    static long SumOfNumbers(int[] numbersArray)
    {
        long resultSum = 0;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            resultSum += numbersArray[i];
        }

        return resultSum;
    }
}

