// Задайте двумерный массив размером М

int strsCount = Convert.ToInt32(Console.ReadLine());
int columnsCount = Convert.ToInt32(Console.ReadLine());

//1 allocate memory for array
int[,] twoDimArray = new int[strsCount, columnsCount];

//2
Random rnd = new Random();
for (int i = 0; i < strsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = rnd.Next(1,100);
        Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
}
