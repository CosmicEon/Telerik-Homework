using System;



class Program
{
    static void Main(string[] args)
    {
        int inputDate = int.Parse(Console.ReadLine());
        //if inputDate is string, it will be converted for structure instance
        //DateTime parsedDate = Convert.ToDateTime(inputDate);

        if (DateTime.IsLeapYear(inputDate))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

