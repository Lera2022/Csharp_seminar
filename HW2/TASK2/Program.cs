// Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// (1, 65537)

int a = new Random().Next(1, 65537);
Console.WriteLine(a);

int digit_first = a / 10000;
int digit_second = (a - digit_first * 10000) / 1000;
int digit_third = (a - digit_first*10000 - digit_second * 1000) / 100;

if(a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
if((99 < a) & (a < 1000))
{
    digit_third = a % 10;
}
if((999 < a) & (a < 10000))
{
    digit_first = a / 1000;
    digit_second = (a - digit_first * 1000) / 100;
    digit_third = (a - digit_first*1000 - digit_second * 100) / 10;
}

Console.WriteLine(digit_third);

