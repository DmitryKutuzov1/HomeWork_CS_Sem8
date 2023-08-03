﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    Console.WriteLine("Результирующая матрица будет:");
    Print2dArray(resultMatrix);
}

void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Fill2DArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m1 = GetInput("Введите количество строк первой матрицы: ");
int n1 = GetInput("Введите количество столбцов первой матрицы: ");
int m2 = GetInput("Введите количество строк второй матрицы: ");
int n2 = GetInput("Введите количество столбцов второй матрицы: ");
if (n1 != m2) Console.WriteLine("Матрицы не согласованы.");
else
{
    int[,] array1 = Fill2DArray(m1, n1, 1, 10);
    int[,] array2 = Fill2DArray(m2, n2, 1, 10);
    Console.WriteLine("Первая матрица:");
    Print2dArray(array1);
    Console.WriteLine("Вторая матрица:");
    Print2dArray(array2);
    MultiplyMatrices(array1, array2);
}