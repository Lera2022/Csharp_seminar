//1. Диапазон
int start = 10;
int stop = 99;
//stack

// 2. Сгенерировать случайное число
int value = new Random().Next(start,stop);
Console. WriteLine(value);
//heap (куча)

//3. Извлечение цифр
int digit_first = value / 10;
int digit_second = value %10;

int max = digit_first;

if(digit_first < digit_second)
{
    max = digit_second;
}

Console.WriteLine("max = " + max);