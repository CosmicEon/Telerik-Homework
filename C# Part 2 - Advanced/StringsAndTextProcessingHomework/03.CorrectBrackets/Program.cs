using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int leftBracket = 0;
            int rightBracket = 0;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if ((inputString[i] == '(') || (inputString[i] == ')'))
                {
                    if (inputString[i] == '(')
                    {
                        leftBracket++;
                    }
                    else if (inputString[i] == ')')
                    {
                        rightBracket++;
                    }
                }
               
            }

            if (leftBracket == rightBracket)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }
    }
}
