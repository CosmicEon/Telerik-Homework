using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder text = new StringBuilder(inputText);

            for (int i = 0; i < inputText.Length - 2; i++)
            {
                if (inputText[i] == inputText[i + 1])
                {
                    inputText.Remove(inputText[i+1],1);
                }
                else if (inputText[i] != inputText[i + 1])
                {
                    continue;
                }
            }
            Console.WriteLine(inputText);
        }
    }
}
