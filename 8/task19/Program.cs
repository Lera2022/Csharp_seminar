// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: n = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int[,] nums = new int[m, n];
Random ran = new Random();
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        nums[i,j] = ran.Next(1, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int tmp = 0;
i = 0;
for (j = 0; j < n; j++)
{
    tmp = nums[i,j];
    nums[i,j] = nums[(m - 1), j];
    nums[(m - 1), j] = tmp;
}

for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
