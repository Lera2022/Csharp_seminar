// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Пожалуйста, введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");

int[] array = new int[N];

int index = 0;
int num = 1;
while (index < N)
{
    array[index] = num * num * num;
    Console.Write(array[index] + ", ");
    num++;
    index++;
}