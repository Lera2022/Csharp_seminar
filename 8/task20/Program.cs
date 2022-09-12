// Составить частотный словарь элементов двумерного массива из целых чисел от 0 до 9. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] counts = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        for (int f = 0; f < 10; f++)
        {
            if (f == nums[i,j])
            {
                counts[f]++;
            }
        }
    }
}

for (int f = 0; f < 10; f++)
{
    
    Console.Write(counts[f] + " ");
}