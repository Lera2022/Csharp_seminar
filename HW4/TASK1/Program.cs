// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Пожалуйста, введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write(A + ", " + B + " -> ");

int i = 0;
int pow = 1;

while (i < B)
{
    pow = pow * A;
    i++;
}

Console.Write(pow);