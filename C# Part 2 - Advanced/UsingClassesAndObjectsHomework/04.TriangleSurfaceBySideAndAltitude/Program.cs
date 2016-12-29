using System;


class Program
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        double surface = side * altitude / 2;

        Console.WriteLine("{0:0.00}", surface);
    }
}

