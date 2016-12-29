using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder modifiedText = new StringBuilder(inputText);
            if (inputText.Length - 1 < 20)
            {
                int difference = 20 - inputText.Length;
                modifiedText.Append('*', difference);

                Console.WriteLine(modifiedText.ToString());
            }
            else if (inputText.Length - 1 == 20)
            {
                Console.WriteLine(inputText);
            }
        }
    }
}
