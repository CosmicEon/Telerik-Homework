using System;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] result = inputNum.ToString().Select(x => Convert.ToInt32(x)).ToArray();

        BinaryToDecimal(result);
    }
    static void BinaryToDecimal(int[] number)
    {
        int result = 0;
        int indexMutilier = 1;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == 1)
            {
                result = result + indexMutilier;
            }
            indexMutilier = indexMutilier * 2;
        }
        Console.WriteLine(result);
    }
}

