using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger inputNum = int.Parse(Console.ReadLine());

            NFactorialOFNum(inputNum);
        }
        static void NFactorialOFNum(BigInteger num)
        {
            BigInteger result = num;
            for (BigInteger i = 1; i < num; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
