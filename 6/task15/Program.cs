// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2-> 10

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[100];
int i = 0;
while (N > 0)
{
    arr[i] = N % 2;
    Console.WriteLine(arr[i]);
    N = N / 2;
    i++;
}
Console.WriteLine("i = " + i);

N = arr[i];
while (i > -1)
{
    N = N * 10 + arr[i];
    i--;
}
Console.WriteLine(N);