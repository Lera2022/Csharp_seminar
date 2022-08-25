// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int a = new Random().Next(1,8);
Console. WriteLine(a);
 
switch (a)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("нет");
        break;
    case 6:
    case 7:
        Console.WriteLine("да");
        break;
}