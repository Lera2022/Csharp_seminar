// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите размер матриц: m = ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m, m];
Random ran1 = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix1[i,j] = ran1.Next(0, 10);
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] matrix2 = new int[m, m];
Random ran2 = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix2[i,j] = ran2.Next(0, 10);
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

void CalcPrdMatrices (int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[m, m];
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
                Console.Write(matrix3[i, j] + " ");
            }
            Console.WriteLine();
        }
}

CalcPrdMatrices (matrix1, matrix2);