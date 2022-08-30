// Напишите программу, которая принимает на вход целое число и выдаёт количество цифр в числе, которые являются чётными (больше среднего арифметического среди всех цифр этого числа (1256 - 2 (ср. арифм. 3.5); 45234 - 3 (ср. арифм. 3.6)); указание: - среднее арифметическое среди цифр числа вычислить в отдельной функции, количество цифр в числе больших заданного вычислить в отдельной функции).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int countOfDigits = 0;

double Avg(int num)
{
    double avg = 0;
    double sum = 0;
    int tmp = num;
    while (tmp > 0)
    {
        int digit = tmp % 10;
        sum = sum + digit;
        countOfDigits++;
        tmp = tmp / 10;
    }
    avg = sum / countOfDigits;
    return avg;
}
double avg = Avg(num);
Console.WriteLine(avg);
countOfDigits = 0;
while (num > 0)
{
    int digit = num % 10;
    if (digit > avg) countOfDigits++;
    num = num / 10;
}
Console.WriteLine(countOfDigits);