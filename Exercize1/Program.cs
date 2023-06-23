
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9




class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[m, n];
        Random random = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10; // Генерация случайного числа от -10 до 10
            }
        }

        // Вывод массива на экран
        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]:F1} ");
            }
            Console.WriteLine();
        }
    }
}
