// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[m, n];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        // Math.Round(-42.132 + rnd.NextDouble() * (7.003 + 42.132), 13) - пример из интернета
        twoDimArray[i, j] = Math.Round(-10 + rnd.NextDouble() * (10.0 + 10.0), 1);
        Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
}