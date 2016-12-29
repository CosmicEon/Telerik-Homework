using System;

class Program
{
    static void Main(string[] args)
    {
        long inputNum = long.Parse(Console.ReadLine());


        DecimalToBinary(inputNum);
    }
    static void DecimalToBinary(long number)
    {
        long remainder;
        string result = string.Empty;
        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            result = remainder.ToString() + result;//in binery convesion we start from right to left
        }
        Console.WriteLine(result);
    }
}
