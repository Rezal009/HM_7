// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 99,25,69,32 },
            { 56,78,20,11 },
            { 13,29,85,22 }
        };

        Console.Write("Введите позицию элемента (строка): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите позицию элемента (столбец): ");
        int col = int.Parse(Console.ReadLine());

        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        if (row >= 0 && row < rowCount && col >= 0 && col < colCount)
        {
            int element = array[row, col];
            Console.WriteLine($"Значение элемента [{row}, {col}]: {element}");
        }
        else
        {
            Console.WriteLine("Такого элемента в массиве нет.");
        }
    }
}
