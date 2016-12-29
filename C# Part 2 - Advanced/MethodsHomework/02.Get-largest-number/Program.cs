using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] arrayOfValues = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        GetMax(arrayOfValues[0], arrayOfValues[1], arrayOfValues[2]);
    }
    static void GetMax(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

