// Задача 3:*(Дополнительная, не обязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)

Console.Write("Пожалуйста, введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(N + ":");

int Sum(int tmp)
{
    int sum = 0;
    while (tmp > 0)
    {
        int digit = tmp % 10;
        sum = sum + digit;
        tmp = tmp / 10;
    }
    return sum;
}

int Prd(int tmp)
{
    int prd = 1;
    while (tmp > 0)
    {
        int digit = tmp % 10;
        if (digit != 0) //исключила из произведения цифру "0", т.к. получались не интересные ответы)
        {
            prd = prd * digit;
        }
        tmp = tmp / 10;
    }
    return prd;
}

int[] array = new int[N];

int tmp = 0;
int index = 0;
while (index < N)
{
    tmp = new Random().Next(1, 2147483647);
    int sum = Sum(tmp);
    int prd = Prd(tmp);
    if (prd % sum == 0)
    {
        array[index] = tmp;
        Console.Write(array[index] + " ");
        Console.Write("(sum = " + sum + "; ");
        Console.WriteLine("prd = " + prd + ")");
        index++;    
    }
}