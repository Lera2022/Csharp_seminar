// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Пожалуйста, введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N);
int firstDigit = N / 10000;
int secondDigit = (N - firstDigit * 10000) / 1000;
int thirdDigit = (N - firstDigit * 10000 -  secondDigit * 1000) / 100;
int fourthDigit =  (N - firstDigit * 10000  -  secondDigit * 1000 - thirdDigit * 100) / 10;
int fifthDigit = N%10;
if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit))
{
    Console.Write(" -> да");
}
else 
{
    Console.Write(" -> нет");
}