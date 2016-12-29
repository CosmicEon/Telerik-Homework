using System;


class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        double radianToAngle = Math.PI * angle / 180.0;//Math.Sin works with radians
        double surface = ((a * b) / 2) * Math.Sin(radianToAngle);

        Console.WriteLine("{0:0.00}", surface);
    }
}

