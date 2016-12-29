using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string matrixSize = Console.ReadLine();
        int[] splitedInput = matrixSize.Split(' ').Select(int.Parse).ToArray();
        int rows = splitedInput[0];
        int cols = splitedInput[1];

        int[,] matrix = new int[rows, cols];
        int maxSum = int.MinValue; //if the maximal sum is negative (-)

        for (int row = 0; row < rows; row++)//reading from console for every row to enter data
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(currentRow[col]);
            }
        }


        for (int row = 0; row < rows-2; row++)
        {
            for (int col = 0; col < cols-2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
            
        }
        Console.WriteLine(maxSum);

    }
}

