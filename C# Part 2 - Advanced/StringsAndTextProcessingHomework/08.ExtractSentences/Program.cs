using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            

            byte[] converted = Encoding.Unicode.GetBytes(inputText);
            Console.WriteLine(converted);
        }
    }
}
