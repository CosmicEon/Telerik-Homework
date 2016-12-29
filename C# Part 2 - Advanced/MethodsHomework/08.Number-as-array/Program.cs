using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputArraysLength = Console.ReadLine();
        int[] twoArraysLength = inputArraysLength.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string firstInputArray = Console.ReadLine();
        int[] firstArray = firstInputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string secondInputArray = Console.ReadLine();
        int[] secondArray = secondInputArray.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int arrayLength = 0;

        if (twoArraysLength[0] > twoArraysLength[1])
        {
            arrayLength = twoArraysLength[0];
        }
        else
        {
            arrayLength = twoArraysLength[1];
        }

        SumOfTwoArrays(firstArray, secondArray, arrayLength);
    }
    static void SumOfTwoArrays(int[] firstArray, int[] secondArray, int arrayLength)
    {
        int[] result = new int[arrayLength];

        bool digitInKeep = false;
        int digitToKeep = 0;
        for (int i = 0; i < arrayLength; i++)
        {

            if (digitInKeep == false)
            {
                if (firstArray[i] + secondArray[i] < 10)
                {
                    result[i] = firstArray[i] + secondArray[i];
                }
                else if (firstArray[i] + secondArray[i] >= 10)
                {
                    //result[i] = ((firstArray[i] + secondArray[i]) - 10);
                    result[i] = ((firstArray[i] + secondArray[i]) % 10) - ((firstArray[i] + secondArray[i]) % (10 / 10));
                    digitToKeep = ((firstArray[i] + secondArray[i]) % 100 - (firstArray[i] + secondArray[i]) % (100 / 10)) / 10;
                    digitInKeep = true;

                }
                else if (firstArray[i] > arrayLength)
                {
                    result[i] = secondArray[i] + digitToKeep;
                }
                else if (secondArray[i] > arrayLength)
                {
                    result[i] = firstArray[i] + digitToKeep;
                }
            }
            else if (digitInKeep == true)
            {
                if (firstArray[i] + secondArray[i] < 10)
                {
                    result[i] = (firstArray[i] + secondArray[i]) + digitToKeep;
                    digitInKeep = false;
                }
                else if (firstArray[i] + secondArray[i] >= 10)
                {
                    result[i] = ((firstArray[i] + secondArray[i]) % 10) - ((firstArray[i] + secondArray[i]) % (10 / 10)) + digitToKeep;
                    digitToKeep = ((firstArray[i] + secondArray[i]) % 100 - (firstArray[i] + secondArray[i]) % (100 / 10)) / 10;
                    digitInKeep = true;
                }
                else if (firstArray[i] > arrayLength)
                {
                    result[i] = secondArray[i] + digitToKeep;
                }
                else if (secondArray[i] > arrayLength)
                {
                    result[i] = firstArray[i] + digitToKeep;
                }
            }
            else if (firstArray.ElementAtOrDefault(i) != null)
            {
                result[i] = secondArray[i];
            }
            else if (firstArray[i] < arrayLength && secondArray[i] > arrayLength)
            {
                result[i] = firstArray[i];
            }
        }
        for (int i = 0; i < result.Length; i++)
        {
            if (i == result.Length - 1)
            {
                Console.WriteLine(result[i]);
                break;
            }
            Console.Write("{0} ", result[i]);
        }
    }

    //this is how to concatenateArrays and it works but it wasn't that I need
    //static void ConcatenateArrays(int[] firstArray, int[] secondArray)
    //{
    //    int[] result = firstArray.Concat(secondArray).ToArray();

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        if (i == result.Length - 1)
    //        {
    //            Console.WriteLine(result[i]);
    //            break;
    //        }
    //        Console.Write("{0} ", result[i]);
    //    }
    //}
}

