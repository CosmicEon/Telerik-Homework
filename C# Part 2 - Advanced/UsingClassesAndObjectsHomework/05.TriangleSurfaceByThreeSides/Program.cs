using System;


class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        double s = (a+b+c) / 2;//heron formula
        double surface = Math.Sqrt(s*(s - a)*(s - b)*(s - c));

        Console.WriteLine("{0:0.00}", surface);
    }
}

