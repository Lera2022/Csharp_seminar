// Задайте двумерный масси из целых числел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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
        nums[i, j] = ran.Next(0, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int min = nums[0, 0];
int MinRowIndex = 0;
int MinColumnIndex = 0;
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        if (nums[i, j] < min)
        {
            min = nums[i, j];
            MinRowIndex = i;
            MinColumnIndex = j;
        }
    }
}

int[,] nums2 = new int[(m - 1), (n - 1)];

for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        int k = i;
        int l = j;
        if ((i == MinRowIndex) || (j == MinColumnIndex))
        {
            continue;
        }
        if (i > MinRowIndex)
        {
            k = i - 1;
        }
        if (j > MinColumnIndex)
        {
            l = j - 1;
        }
        nums2[k, l] = nums[i, j];
        Console.Write(nums2[k, l] + " ");
    }
    Console.WriteLine();
}