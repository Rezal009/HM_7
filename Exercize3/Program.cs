// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




int[,] array = {
            {5,47,3,2,10},
            {7,55,35,7,11},
            {5,420,3,2,10}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        double[] columnAverages = new double[cols];

        for (int col = 0; col < cols; col++)
        {
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                sum += array[row, col];
            }

            columnAverages[col] = (double)sum / rows;
        }

        Console.WriteLine("Среднее арифметическое каждого столбца:");

        for (int col = 0; col < cols; col++)
        {
            Console.WriteLine(columnAverages[col]);
        }