/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;
Clear();
WriteLine("Введите число n: ");
int n = int.Parse(ReadLine());
WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
int [,] array = GetArray(m, n, 0, 10);
PrintArray(array);
WriteLine();

WriteLine(String.Join(", ", GetAref(array)));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next( minValue, maxValue + 1);
        }
    }
    return result;
}


double[] GetAref(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arr[j] = sum / array.GetLength(0);
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

