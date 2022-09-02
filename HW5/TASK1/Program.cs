// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("[");

int[] array = new int[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write(array[i] + ", ");
    if (array[i] % 2 == 0)
    {
        count++;
    }
    
}
Console.WriteLine("] -> " + count);