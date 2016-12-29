using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int martixSize = int.Parse(Console.ReadLine()); //matrix size will always be square
        char typeOfMatrix = char.Parse(Console.ReadLine());


        int[,] matrix = new int[martixSize, martixSize];
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int inputNum = 1;

        if (typeOfMatrix == 'a') //case a
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[col, row] = inputNum;
                    inputNum++;
                }
            }
            printMatrix(matrix);
        }
        else if (typeOfMatrix == 'b') //case b
        {
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[col, row] = inputNum;
                        inputNum++;
                    }
                }
                else
                {
                    for (int col = cols - 1; 0 <= col; col--)
                    {
                        matrix[col, row] = inputNum;
                        inputNum++;
                    }
                }
            }
            printMatrix(matrix);
        }
        else if (typeOfMatrix == 'c') //case c
        {

            int maxSum = rows + cols - 2;
            int[,] reworkedMatrix = new int[martixSize, martixSize];

            for (int sum = 0; sum <= maxSum; sum++)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (row + col - sum == 0)
                        {
                            matrix[col, row] = inputNum;
                            inputNum++;
                        }
                    }
                }
            }
            //at the end rotate the matrix, couldn't modify formula
            for (int i = 0; i < martixSize; i++)
            {
                for (int j = 0; j < martixSize; j++)
                {
                    reworkedMatrix[j, i] = matrix[martixSize - j - 1, i];
                }
            }


            printMatrix(reworkedMatrix);
        }
        else if (typeOfMatrix == 'd') //case d
        {
            int row = 0;
            int col = 0;
            string direction = "down";
            int maxRotations = martixSize * martixSize;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "down" && (row > martixSize - 1 || matrix[row, col] != 0))
                {
                    
                    direction = "right";
                    row--;
                    col++;
                   
                }
                if (direction == "right" && (col > martixSize - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                   
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                   
                }

                

                matrix[row, col] = i;

               
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "up")
                {
                    row--;
                }
                if (direction == "left")
                {
                    col--;
                }
            }
            printMatrix(matrix);
        }
        

    }
    static void printMatrix(int[,] matrix) //print method
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col == matrix.GetLength(1) - 1)
                {
                    Console.Write("{0}", matrix[row, col]);
                    break;
                }
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

}
