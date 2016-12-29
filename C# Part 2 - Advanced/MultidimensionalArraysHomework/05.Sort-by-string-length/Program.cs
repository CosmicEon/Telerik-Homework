using System;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        string inputArray = Console.ReadLine();//if the array is string of values separated by space
        string[] splitedArray = inputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] orderedArray = splitedArray.OrderBy(x => x).ThenBy(x => x.Length).ToArray();//sorts by alphabetical then by length

    }
}

