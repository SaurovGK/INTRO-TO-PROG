﻿// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int LineDia(int[,] array)
{
    int sum = 0;
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            if (i==j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
      for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) ; j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, - 10, 10);
int sum = LineDia(array2D);
PrintArray(array2D);
Console.WriteLine();
Console.Write(sum);
