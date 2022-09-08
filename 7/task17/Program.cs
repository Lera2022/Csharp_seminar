// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[M, N];
Random ran = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        nums[i,j] = ran.Next(1, 10);
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (i % 2 == 0 && j % 2 ==0)
        {
            nums[i,j] = nums[i,j] * nums[i,j];
        }
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}