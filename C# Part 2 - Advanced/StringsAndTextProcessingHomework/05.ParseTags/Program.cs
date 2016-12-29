using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            int leftSide = inputText.IndexOf("<upcase>");
            int rightSide = inputText.IndexOf("</upcase>");
            int index = 0;
            inputText =
            while (true)
            {
                char[] textToUpper = inputText.ToList().GetRange(leftSide, rightSide - leftSide).ToArray();
                if (leftSide < 0)
                {
                    break;
                }
                textToUpper.ToString().ToUpper();
                Console.WriteLine(textToUpper);

                index = rightSide + 1;
            }
            for (int i = 0; i < inputText.Length - 1; i++)
            {
                string[] range = inputText.GetRange(inputText.IndexOf("<upcase>"), inputText.IndexOf("</upcase>"))
            }
            
            //int leftSide = inputText.IndexOf("<upcase>");
            //int rightSide = inputText.IndexOf("</upcase>");
            //for (int i = 0; i < inputText.Length - 1; i++)
            //{

            //}
        }
    }
}
