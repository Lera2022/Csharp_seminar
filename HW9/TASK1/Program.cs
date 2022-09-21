// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов в массиве: n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];
Random ran = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = ran.Next(1, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

void SortRows(ref int[,] nums)
{
    int[] temp = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            temp[j] = nums[i, j];
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int k = 0; k < n; k++)
        {
            nums[i, k] = temp[k];
            Console.Write(nums[i, k] + " ");
        }
        Console.WriteLine();
    }
}

SortRows(ref nums);