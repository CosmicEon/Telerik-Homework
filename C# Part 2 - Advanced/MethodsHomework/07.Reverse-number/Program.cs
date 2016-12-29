using System;

class Program
{
    static void Main(string[] args)
    {
        string inputNum = Console.ReadLine();

        
        ReverseNumber(inputNum);
    }
    static void ReverseNumber(string number)
    {
        char[] charArray = number.ToCharArray();//string --> char array
        char[] reversedArray = new char[charArray.Length];

        for (int i = 0; i < charArray.Length; i++)//reverse array
        {
            reversedArray[i] = charArray[charArray.Length - i - 1];
        }

        string result = string.Join("", reversedArray);
        Console.WriteLine(result);
    }
}
