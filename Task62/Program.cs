﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]}\t");
            else Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillSpiralArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int num = 1;
    int rowStart = 0, rowEnd = spiralArray.GetLength(0) - 1;
    int columnStart = 0, columnEnd = spiralArray.GetLength(1) - 1;

    while (num <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        for (int i = columnStart; i <= columnEnd; i++)
        {
            spiralArray[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralArray[i, columnEnd] = num++;
        }
        columnEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = columnEnd; i >= columnStart; i--)
            {
                spiralArray[rowEnd, i] = num++;
            }
            rowEnd--;
        }

        if (columnStart <= columnEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralArray[i, columnStart] = num++;
            }
            columnStart++;
        }
    }
    return spiralArray;
}

int[,] array = FillSpiralArray(4, 4);
Print2dArray(array);