/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
using System;
using static System.Console;
Clear();
Write("Enter rows: ");
int rows = int.Parse(ReadLine());
Write("Enter columns: ");
int columns = int.Parse(ReadLine());
Write("Enter rows position: ");
int rowsp = int.Parse(ReadLine());
Write("Enter columns position: ");
int columnsp = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);
PrintArrayPosition(array, rowsp, columnsp);


int[,] GetArray(int r, int c, int minValue, int maxValue)
{
    int[,] resulte = new int[r,c];
    for(int i = 0; i < r; i++)
    {
        for(int j = 0; j < c; j++)
        {
            resulte[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resulte;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Write($"{array[i,j]} ");
}
WriteLine();
}
}

void PrintArrayPosition(int[,] array, int a, int b)
{
    if(a <= array.GetLength(0) && b <= array.GetLength(1))
    {
        Write($"{array[a,b]}");
    }
    else
    {
        Write("no");
    }
}