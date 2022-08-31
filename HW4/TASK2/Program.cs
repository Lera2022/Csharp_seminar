// Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать)
// 452 -> 6
// 82 -> 2
// 9012 -> 3
// 23 -> 0

Console.Write("Пожалуйста, введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");

int digit = 0;
int sum = 0;
int tmp = N;

while (tmp > 0)
{
    digit = tmp % 10;
    if (digit == 0)
    {
        tmp = tmp / 10;
    }
    else if (N % digit == 0)
    {
        sum = sum + digit;
    }
    tmp = tmp / 10;
}

Console.Write(sum);