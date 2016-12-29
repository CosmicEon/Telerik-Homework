using System;


class EnterNumbers
{
    static void Main()
    {
        int[] inputData = new int[10];
        for (int i = 0; i < inputData.Length; i++)
        {
            inputData[i] = int.Parse(Console.ReadLine());
        }

        ReadNumber(inputData);
    }

    static void ReadNumber(int[] array)
    {
        Array.Sort(array);
        string newArray = string.Join(" < ", array);
        Console.WriteLine("1 < " + newArray + " < 100");
    }
}

