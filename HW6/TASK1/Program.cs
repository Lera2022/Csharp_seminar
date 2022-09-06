// Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Пожалуйста введите натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write("Пожалуйста введите число №" + (i + 1) + ": ");
    int tmp = Convert.ToInt32(Console.ReadLine());
    if (tmp > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество положительных чисел: " + count);