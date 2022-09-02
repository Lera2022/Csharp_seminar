// Задача 3*: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write("Введите элемент с индексом " + i + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int Max(int[] array)
{
    int max = array[0];
    for (int j = 1; j < N; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < N; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int max = Max(array);
int min = Min(array);
int dif = max - min;
Console.WriteLine(dif);