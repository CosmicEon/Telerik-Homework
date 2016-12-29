using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                string inputString = Console.ReadLine();
                //int num;

                //dont know how to check if input is text
                //if (int.TryParse(inputString, out num))
                //{
                //    throw new Exception("Invalid number");
                //}

                double inputNum = double.Parse(inputString);

                if (inputNum < 0)
                {
                    throw new Exception("Invalid number");
                }

                Console.WriteLine("{0:0.000}", Math.Sqrt(inputNum));
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Invalid number");
            }
            catch (FormatException)
            {
                throw new Exception("Invalid number");
            }
            catch (OverflowException)
            {
                throw new Exception("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
