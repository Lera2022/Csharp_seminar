// Задача 1: Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int a = new Random().Next(100,1000);
Console. WriteLine(a);
int digit_first = a / 100;
int digit_second = (a-digit_first*100)/10;
Console. WriteLine(digit_second);