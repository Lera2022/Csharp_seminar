// Задача 2*. Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
// *Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Указание:
// При заполнении массива использовать циклы.

int[,] nums = new int[4, 4];
int n = 4;
int i = 0;
int j = 0;
int count = 1;

for (j = 0; j < n; j++)
{
    nums[i, j] = count;
    count++;
}
j = j - 1;
for (i = 1; i < n; i++)
{
    nums[i, j] = count;
    count++;
}
i = i - 1;
for (j = 2; j >= 0; j--)
{
    nums[i, j] = count;
    count++;
}
j = j + 1;
for (i = 2; i > 0; i--)
{

    nums[i, j] = count;
    count++;
}
i = i + 1;
for (j = 1; j < n - 1; j++)
{
    nums[i, j] = count;
    count++;
}
i = i + 1;
for (j = 2; j > 0; j--)
{
    nums[i, j] = count;
    count++;
}

for (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        if (nums[i, j] < 10)
        {
            Console.Write("0" + nums[i, j] + " ");
        }
        else
        {
        Console.Write(nums[i, j] + " ");
        }
    }
    Console.WriteLine();
}