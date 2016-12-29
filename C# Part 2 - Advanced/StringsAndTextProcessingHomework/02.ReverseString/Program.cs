using System;



class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string reversedString = "";
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedString += inputString[i];
        }

        Console.WriteLine(reversedString);
    }
}

