﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckNumber(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return false;
            }
        }
    }
    return true;
}

void Print3dArray(int[,,] massive)
{
    for (int k = 0; k < massive.GetLength(2); k++)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write($"{massive[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Fill3DArray(int rows, int columns, int pages, int startValue, int finishValue)
{
    int[,,] matrix = new int[rows, columns, pages];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                int number = new Random().Next(startValue, finishValue);
                if (CheckNumber(matrix, number)) matrix[i, j, k] = number;
                else k--;
            }
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите количество строк: ");
int y = GetInput("Введите количество столбцов: ");
int z = GetInput("Введите глубину: ");
int[,,] array = Fill3DArray(x, y, z, 1, 100);
Print3dArray(array);