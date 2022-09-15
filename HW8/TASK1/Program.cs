// Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        nums[i,j] = ran.Next(0, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Суммы элементов в каждой строке:");
int[] sums = new int[m];
for (i = 0; i < m; i++)
{
     for (j = 0; j < n; j++)
    {
        sums[i] = sums[i] + nums[i, j];
    }
        
}

int min = sums[0];
int minIndex = 0;
for (i = 0; i < m; i++)
{
    Console.Write(sums[i] + " ");
    if (sums[i] < min)
    {
        min = sums[i];
        minIndex = i;
    }
}

Console.WriteLine("=> строка с наименьшей суммой элементов: " + (minIndex + 1) + " строка");
