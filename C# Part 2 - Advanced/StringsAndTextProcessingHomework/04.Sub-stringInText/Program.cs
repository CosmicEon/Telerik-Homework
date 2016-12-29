using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPattern = Console.ReadLine();
            string inputText = Console.ReadLine();
            inputText.ToUpper();


            int foundPattern = 0;
            int index = 0;
            while (true)
            {                                                      //this under makes case insensiteve
                int found = inputText.IndexOf(inputPattern, index, StringComparison.CurrentCultureIgnoreCase);
                if (found < 0)//if cicles 2nd time last element in found group will tryo to switch
                {
                    break;
                }
                foundPattern++;
                index = found + 1;
            }
            for (int i = 0; i < inputPattern.Length - 1; i++)
            {
                if (true)
                {

                }
            }
            Console.WriteLine(foundPattern);
        }
    }
}
