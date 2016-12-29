using System;


class Program
{
    static void Main()
    {
        string inputName = Console.ReadLine();

        PrintName(inputName);
    }

    static void PrintName(string name)
    {

        Console.WriteLine("Hello, {0}!", name);

    }
}

